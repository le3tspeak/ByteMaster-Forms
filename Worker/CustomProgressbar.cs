using System.ComponentModel;

namespace Game_Server_Manager.Worker;

public enum TextPosition
{
    Left,
    Right,
    Center,
    Sliding,
    None
}

internal class CustomProgressbar : ProgressBar
{
    // Fields
    private Color channelColor = Color.LightSteelBlue;
    private Color sliderColor = Color.RoyalBlue;
    private Color foreBackColor = Color.RoyalBlue;
    private int channelHeight = 6;
    private int sliderHeight = 6;
    private TextPosition showValue = TextPosition.Right;

    // Others
    private bool paintedBack = false;
    private bool stopPainting = false;

    // Constructor
    public CustomProgressbar()
    {
        this.SetStyle(ControlStyles.UserPaint, true);
        this.ForeColor = Color.White;
    }

    // Properties
    [Category("CustomProgressbar")]
    public Color ChannelColor
    {
        get
        {
            return channelColor;
        }

        set
        {
            channelColor = value;
            this.Invalidate();
        }
    }

    [Category("CustomProgressbar")]
    public Color SliderColor
    {
        get
        {
            return sliderColor;
        }

        set
        {
            sliderColor = value;
            this.Invalidate();
        }
    }

    [Category("CustomProgressbar")]
    public Color ForeBackColor
    {
        get
        {
            return foreBackColor;
        }

        set
        {
            foreBackColor = value;
            this.Invalidate();
        }
    }

    [Category("CustomProgressbar")]
    public int ChannelHeight
    {
        get
        {
            return channelHeight;
        }

        set
        {
            channelHeight = value;
            this.Invalidate();
        }
    }

    [Category("CustomProgressbar")]
    public int SliderHeight
    {
        get
        {
            return sliderHeight;
        }

        set
        {
            sliderHeight = value;
            this.Invalidate();
        }
    }

    [Category("CustomProgressbar")]
    public TextPosition ShowValue
    {
        get
        {
            return showValue;
        }

        set
        {
            showValue = value;
        }
    }

    [Category("CustomProgressbar")]
    [Browsable(true)]
    [EditorBrowsable(EditorBrowsableState.Always)]
    public override Font Font
    {
        get
        {
            return base.Font;
        }

        set
        {
            base.Font = value;
        }
    }

    [Category("CustomProgressbar")]
    public override Color ForeColor
    {
        get
        {
            return base.ForeColor;
        }

        set
        {
            base.ForeColor = value;
        }
    }

    //-> Paint the background & channel
    protected override void OnPaintBackground(PaintEventArgs pevent)
    {
        if (stopPainting == false)
        {
            if (paintedBack == false)
            {
                // Fields
                Graphics graph = pevent.Graphics;
                Rectangle rectChannel = new Rectangle(0, 0, this.Width, ChannelHeight);
                using (var brushChannel = new SolidBrush(channelColor))
                {
                    if (channelHeight >= sliderHeight)
                        rectChannel.Y = this.Height - channelHeight;
                    else rectChannel.Y = this.Height - ((sliderHeight + sliderHeight) / 2);

                    // Painting
                    graph.Clear(this.Parent.BackColor); // Surface
                    graph.FillRectangle(brushChannel, rectChannel); // Channel

                    // Stop painting the background & channel
                    if (this.DesignMode == false)
                        paintedBack = true;
                }
            }

            // Reset painting the background & channel
            if (this.Value == this.Maximum || this.Value == this.Minimum)
                paintedBack = false;
        }
    }

    //-> Paint the slider
    protected override void OnPaint(PaintEventArgs e)
    {
        if (stopPainting == false)
        {
            // Fields
            Graphics graph = e.Graphics;
            double scaleFactor = (((double)this.Value - this.Minimum) / ((double)this.Maximum - this.Minimum));
            int sliderWidth = (int)((this.Width) * scaleFactor);
            Rectangle rectSlider = new Rectangle(0, 0, sliderWidth, sliderHeight);
            using (var brushSlider = new SolidBrush(sliderColor))
            {
                if (sliderHeight >= channelHeight)
                    rectSlider.Y = this.Height - sliderHeight;
                else rectSlider.Y = this.Height - ((channelHeight + sliderHeight) / 2);

                // Painting
                if (sliderWidth > 1) // Slider
                    graph.FillRectangle(brushSlider, rectSlider);
                if (showValue != TextPosition.None) // Text
                    DrawValueText(graph, sliderWidth, rectSlider);

            }

        }
    }

    //-> Paint value text
    private void DrawValueText(Graphics graph, int sliderWidth, Rectangle rectSlider)
    {
        string text = this.Value.ToString() + " %";
        var textSize = TextRenderer.MeasureText(text, this.Font);
        var rectText = new Rectangle(0, 0, textSize.Width, textSize.Height + 2);
        using (var brushText = new SolidBrush(this.ForeColor))
        using (var bruschTextBack = new SolidBrush(foreBackColor))
        using (var textFormat = new StringFormat())
        {
            switch (showValue)
            {
                case TextPosition.Left:
                    rectText.X = 0;
                    textFormat.Alignment = StringAlignment.Near;
                    break;
                case TextPosition.Right:
                    rectText.X = this.Width - textSize.Width;
                    textFormat.Alignment = StringAlignment.Far;
                    break;
                case TextPosition.Center:
                    rectText.X = (this.Width - textSize.Width) / 2;
                    textFormat.Alignment = StringAlignment.Center;
                    break;
                case TextPosition.Sliding:
                    rectText.X = sliderWidth - textSize.Width;
                    textFormat.Alignment = StringAlignment.Center;
                    // Clean previous text surface
                    using (var brushClear = new SolidBrush(this.Parent.BackColor))
                    {
                        var rect = rectSlider;
                        rect.Y = rectText.Y;
                        rect.Height = rect.Height;
                        graph.FillRectangle(brushClear, rect);
                    }
                    break;
            }

            // Painting
            graph.FillRectangle(bruschTextBack, rectText);
            graph.DrawString(text, this.Font, brushText, rectText, textFormat);
        }
    }
}
