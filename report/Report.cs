using System.Data;

namespace UkrPoshta.report
{
    internal class Report : IReport
    {
        public void WriteTable(DataGridViewColumnCollection columns, DataGridViewRowCollection rows)
        {
            using (var streamWriter = new StreamWriter($"{Environment.CurrentDirectory}\\Звіт\\Звіт {DateTime.UtcNow: dd.mm.yyyy hh-mm-ss}.txt"))
            {
                for (int i = 0; i < rows.Count - 1; i++)
                {
                    for (int j = 0; j < columns.Count; j++)
                    {
                        streamWriter.Write($"{rows[i].Cells[j].Value}");

                        if (!(j == columns.Count - 1))
                        {
                            streamWriter.Write("       ");
                        }
                    }
                    streamWriter.WriteLine("\n");
                }
                streamWriter.Close();
            }
        }
    }
}
