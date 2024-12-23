using System.Text;

namespace DragoAnt.Extensions.T4;

public static class CSharpCodeExtensions
{
    public static string ConvertToDocumentationComment(string? value, string ident)
    {
        var comment = value ?? string.Empty;
        var lines = comment.Split('\r', '\n');
        var builder = new StringBuilder();
        foreach (var line in lines)
        {
            builder.Append(ident);
            builder.Append("///");
            builder.Append(' ');
            builder.AppendLine(line.TrimEnd());
        }

        if (builder.Length == 0)
        {
            builder.Append(ident);
            builder.Append("///");
        }

        return builder.ToString().TrimEnd('\r', '\n');
    }
}