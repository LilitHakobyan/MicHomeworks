using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetADDReadeImageFromDB
{
    public class ImageModel
    {
        public ImageModel(int id, string filename, string title, byte[] data)
        {
            Id = id;
            FileName = filename;
            Title = title;
            Data = data;
        }
        public int Id { get;  set; }
        public string FileName { get;  set; }
        public string Title { get;  set; }
        public byte[] Data { get;  set; }
    }
}
