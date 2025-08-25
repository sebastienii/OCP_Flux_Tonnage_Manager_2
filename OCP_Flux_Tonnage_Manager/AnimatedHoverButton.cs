using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class AnimatedHoverButton : Button
{
    public Color NormalBackColor { get; set; } = Color.FromArgb(0, 122, 255);
    public Color HoverBackColor { get; set; } = Color.FromArgb(109, 213, 237); // #6dd5ed
    public Color TextColor { get; set; } = Color.White;
    public int BorderRadius { get; set; } = 20;

    private bool isHover = false;
    private Color currentBackColor;
    private Color currentTextColor;

    private Timer animationTimer;
    private float animationStep = 0.1f; // Vitesse de transition
    private float animationProgress = 0f; // Progression de l'animation (0 à 1)

    public AnimatedHoverButton()
    {
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        BackColor = NormalBackColor;
        currentBackColor = NormalBackColor;
        currentTextColor = TextColor;
        Font = new Font("Segoe UI", 10, FontStyle.Bold);
        Cursor = Cursors.Hand;
        DoubleBuffered = true;

        MouseEnter += (s, e) => { isHover = true; StartAnimation(); };
        MouseLeave += (s, e) => { isHover = false; StartAnimation(); };

        // Timer pour animer
        animationTimer = new Timer();
        animationTimer.Interval = 30; // ms
        animationTimer.Tick += Animate;
    }

    private void StartAnimation()
    {
        // Définir la direction de l'animation
        if (isHover)
        {
            animationProgress = 0f;
        }
        else
        {
            animationProgress = 1f;
        }
        animationTimer.Start();
    }

    private void Animate(object sender, EventArgs e)
    {
        if (isHover)
        {
            if (animationProgress < 1f)
            {
                animationProgress += animationStep;
                if (animationProgress > 1f) animationProgress = 1f;
            }
        }
        else
        {
            if (animationProgress > 0f)
            {
                animationProgress -= animationStep;
                if (animationProgress < 0f) animationProgress = 0f;
            }
        }

        currentBackColor = InterpolateColor(NormalBackColor, HoverBackColor, animationProgress);
        // La couleur du texte reste blanche, mais vous pouvez la faire interpoler aussi si désiré
        currentTextColor = TextColor;

        if ((isHover && animationProgress >= 1f) || (!isHover && animationProgress <= 0f))
        {
            animationTimer.Stop();
        }

        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        using (GraphicsPath path = RoundedRect(new Rectangle(0, 0, Width, Height), BorderRadius))
        {
            pevent.Graphics.FillPath(new SolidBrush(currentBackColor), path);

            // Optionally, draw icon or text here
            TextRenderer.DrawText(pevent.Graphics, Text, Font, new Rectangle(0, 0, Width, Height), currentTextColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }

    private Color InterpolateColor(Color c1, Color c2, float t)
    {
        int r = (int)(c1.R + (c2.R - c1.R) * t);
        int g = (int)(c1.G + (c2.G - c1.G) * t);
        int b = (int)(c1.B + (c2.B - c1.B) * t);
        return Color.FromArgb(r, g, b);
    }

    private GraphicsPath RoundedRect(Rectangle bounds, int radius)
    {
        int diameter = radius * 2;
        GraphicsPath path = new GraphicsPath();

        path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
        path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
        path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
        path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
        path.CloseFigure();

        return path;
    }
}