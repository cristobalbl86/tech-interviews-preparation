using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CodingInterview.VanHack
{
    class SortCSV
    {
        public static string SortCsvColumns(string csv_data)
        {
            string[] lines = csv_data.Split(new[] { '\n' });
            DataTable dt = new DataTable();
            bool first = true;
            string[] cols = null;
            string result = string.Empty;

            //pass csv string to datatable
            foreach (string line in lines)
            {
                //Console.WriteLine(line);
                if (first)
                {
                    cols = line.Split(",");

                    foreach (string col in cols)
                    {
                        dt.Columns.Add(col, typeof(string));
                    }
                    first = false;
                }
                else
                {
                    dt.Rows.Add(line.Split(","));
                }
            }

            //sort columns in datatble
            Array.Sort(cols);
            int order = 0;
            foreach (string col in cols)
            {
                dt.Columns[col].SetOrdinal(order++);
            }

            //convert datatable to string
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Join(",", cols) + "\n");
            List<string> items = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                foreach (string col in cols)
                {
                    items.Add(dr[col].ToString());
                }
                sb.Append(string.Join(",", items) + "\n");
                items = new List<string>();
            }

            result = sb.ToString();
            result = result.Remove(result.LastIndexOf("\n"));
            return result;
        }
    }
}
