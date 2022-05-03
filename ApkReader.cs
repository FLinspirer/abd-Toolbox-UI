using AndroidXml;
using System.Data;
using System.IO;
using System.Linq;
using System.Xml;
using SharpCompress.Archives;


namespace ApkInfo
{
    public static class PackageReader
    {

        /// <summary>
        /// 获取Apk包名
        /// </summary>
        /// <param name="stream">文件流</param>
        /// <returns></returns>
        public static string GetPackageNameFromApk(Stream stream)
        {
            using (IArchive zipReader = ArchiveFactory.Open(stream))
            {
                IArchiveEntry adf = zipReader.Entries.FirstOrDefault(w => w.Key == "AndroidManifest.xml");

                if (adf == null)
                {
                    return string.Empty;
                }

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    adf.OpenEntryStream().CopyTo(memoryStream);
                    memoryStream.Seek(0, SeekOrigin.Begin);
                    AndroidXmlReader reader = new AndroidXmlReader(memoryStream);
                    while (reader.Read())
                    {
                        switch (reader.NodeType)
                        {
                            case XmlNodeType.Element:
                                for (int i = 0; i < reader.AttributeCount; i++)
                                {
                                    reader.MoveToAttribute(i);
                                    if (reader.Name != "package")//只读取包名的过滤条件
                                    {
                                        continue;
                                    }
                                    return reader.Value;
                                }
                                reader.MoveToElement();
                                break;
                        }
                    }
                }


                return string.Empty;
            }
        }

    }
}

