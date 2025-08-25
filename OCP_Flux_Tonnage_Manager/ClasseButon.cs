using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ModernUIButton
{
    public class ModernButton : Button
    {
        private bool isHovered = false;
        private Timer animationTimer;
        private float animationProgress = 0f; // 0 = normal, 1 = hover
        private readonly float animationStep = 0.1f; // Vitesse d'animation

        // Couleur normale
        public Color NormalBackColor { get; set; } = Color.FromArgb(3, 225, 188);
        // Couleur d'effet au survol (ARGB 27, 89, 84)
        public Color HoverBackColor { get; set; } = Color.FromArgb(27, 89, 84);
        public Color TextColor { get; set; } = Color.Black;

        public ModernButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = NormalBackColor;
            this.ForeColor = TextColor;
            this.Font = new Font("Arial", 14, FontStyle.Bold);
            this.Size = new Size(120, 40);
            this.Text = "Save";

            // Initialisation du timer
            animationTimer = new Timer();
            animationTimer.Interval = 30; // ms
            animationTimer.Tick += Animate;

            // Événements de survol
            this.MouseEnter += (s, e) => { isHovered = true; StartAnimation(); };
            this.MouseLeave += (s, e) => { isHovered = false; StartAnimation(); };
        }

        private void StartAnimation()
        {
            // Démarre ou continue l'animation
            animationTimer.Start();
        }

        private void Animate(object sender, EventArgs e)
        {
            if (isHovered)
            {
                if (animationProgress < 1f)
                {
                    animationProgress += animationStep;
                    if (animationProgress > 1f) animationProgress = 1f;
                }
                else
                {
                    animationTimer.Stop();
                }
            }
            else
            {
                if (animationProgress > 0f)
                {
                    animationProgress -= animationStep;
                    if (animationProgress < 0f) animationProgress = 0f;
                }
                else
                {
                    animationTimer.Stop();
                }
            }

            // Interpoler la couleur de fond vers la couleur de survol
            this.BackColor = InterpolateColor(NormalBackColor, HoverBackColor, animationProgress);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectSurface = this.ClientRectangle;
            int borderRadius = 17;

            using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
            using (SolidBrush brushSurface = new SolidBrush(this.BackColor))
            {
                this.Region = new Region(pathSurface);
                pevent.Graphics.FillPath(brushSurface, pathSurface);

                // Dessiner le texte au centre
                TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, rectSurface,
                    this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private Color InterpolateColor(Color c1, Color c2, float t)
        {
            int r = (int)(c1.R + (c2.R - c1.R) * t);
            int g = (int)(c1.G + (c2.G - c1.G) * t);
            int b = (int)(c1.B + (c2.B - c1.B) * t);
            return Color.FromArgb(r, g, b);
        }
    }
}