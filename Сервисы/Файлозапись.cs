using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Практика_2._0.Модели;

namespace Практика_2._0.Сервисы
{
    internal class Файлозапись
    {
        private readonly string PATH;

        public Файлозапись(string path)
        {
            PATH = path;
        }

        public BindingList<WriterInGreeder> LoadData()
        {
            var fileExists = File.Exists(PATH);
            if (!fileExists)
            {
                File.CreateText(PATH).Dispose();
                return new BindingList<WriterInGreeder>();
            }
            using (var reader = File.OpenText(PATH))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<WriterInGreeder>>(fileText);
            }
        }

        public void SaveData(object _wigDataList)
        {
            using (StreamWriter writer = File.CreateText(PATH))
            {
                string output = JsonConvert.SerializeObject(_wigDataList);
                writer.WriteLine(output);
            }
        }
    }
}
