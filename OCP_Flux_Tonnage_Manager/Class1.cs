using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ModernButton : Button
{
    public Color NormalBackColor { get; set; } = Color.FromArgb(0, 122, 255);
    public Color HoverBackColor { get; set; } = Color.FromArgb(0, 105, 217);
    public Color TextColor { get; set; } = Color.White;
    public int BorderRadius { get; set; } = 20;

    // Nouvelle propriété pour l'icône
    public Image Icon { get; set; }
    public int IconSize { get; set; } = 20; // Taille de l'icône
    public int IconPadding { get; set; } = 8; // Espace entre l'icône et le texte

    private bool isHover = false;

    public ModernButton()
    {
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        BackColor = NormalBackColor;
        ForeColor = TextColor;
        Font = new Font("Segoe UI", 10, FontStyle.Bold);
        Cursor = Cursors.Hand;
        DoubleBuffered = true;

        MouseEnter += (s, e) => { isHover = true; Invalidate(); };
        MouseLeave += (s, e) => { isHover = false; Invalidate(); };
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        Color backColor = isHover ? HoverBackColor : NormalBackColor;

        using (GraphicsPath path = RoundedRect(new Rectangle(0, 0, Width, Height), BorderRadius))
        {
            // Remplir le fond
            pevent.Graphics.FillPath(new SolidBrush(backColor), path);

            // Dessiner l'icône si elle est définie
            int iconX = Icon != null ? IconPadding : 0;
            int iconY = (Height - IconSize) / 2;

            if (Icon != null)
            {
                pevent.Graphics.DrawImage(Icon, new Rectangle(iconX, iconY, IconSize, IconSize));
            }

            // Préparer le texte à dessiner
            string textToDraw = Text;
            int textX = Icon != null ? IconPadding + IconSize + IconPadding : 0;

            // Définir la zone de texte
            Rectangle textRect = new Rectangle(
                textX,
                0,
                Width - textX,
                Height);

            // Dessiner le texte centré verticalement
            TextRenderer.DrawText(pevent.Graphics, textToDraw, Font, textRect, ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }

    private GraphicsPath RoundedRect(Rectangle bounds, int radius)
    {
        int diameter = radius * 2;
        GraphicsPath path = new GraphicsPath();

        path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
        path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
        path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
        path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
        path.CloseAllFigures();

        return path;
    }
}