using Xceed.Document.NET;

namespace SAMSITCMiniLIS.Shared
{
    public class DocGenerator
    {
        private double getAverageofMarkers(string[] values)
        {
            int sum = 0;
            int count = 0;
            foreach (var v in values)
            {
                if (!string.IsNullOrEmpty(v))
                {
                    sum += int.Parse(v);
                    count++;
                }
            }
            return count > 0 ? (double)sum / count : 0;
        }
        private void setCellValueIfNotNull(string key, string value, Xceed.Document.NET.Table table)
        {
            if (!string.IsNullOrEmpty(value))
            {
                var newRow = table.InsertRow();
                newRow.Cells[0].Paragraphs.First().Append(key).FontSize(16);
                newRow.Cells[1].Paragraphs.First().Append(value).FontSize(14).Alignment = Alignment.center;
            }
        }
        private void setMarkerValueIfNotNull(string marker, string expressed, string gated, string total, Xceed.Document.NET.Table table)
        {

            if (!string.IsNullOrEmpty(expressed) || !string.IsNullOrEmpty(gated) || !string.IsNullOrEmpty(total))
            {
                var newRow = table.InsertRow();
                newRow.Cells[0].Paragraphs.First().Append(marker).FontSize(16);
                newRow.Cells[1].Paragraphs.First().Append(expressed).FontSize(14).Alignment = Alignment.center;
                newRow.Cells[2].Paragraphs.First().Append(gated).FontSize(14).Alignment = Alignment.center;
                newRow.Cells[3].Paragraphs.First().Append(total).FontSize(14).Alignment = Alignment.center;
            }

        }

    }
}
