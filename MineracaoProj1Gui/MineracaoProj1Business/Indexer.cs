using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineracaoProj1Business
{
    public class Indexer
    {
        private IndexWriter writer;

        public Indexer(string type)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Constants.INDEX);
            Lucene.Net.Store.Directory directory = FSDirectory.Open(directoryInfo);
            Analyzer analyzer = AnalizerF.Factory(type); 

            this.writer = new IndexWriter(directory, analyzer, IndexWriter.MaxFieldLength.UNLIMITED);
        }

        public int IndexFiles(string filesPath)
        {
            this.writer.DeleteAll();
            string[] files = System.IO.Directory.GetFiles(filesPath);

            foreach (string filePath in files)
                _IdexFile(filePath);

            return this.writer.NumDocs();
        }

        public void Close()
        {
            this.writer.Optimize();
            this.writer.Dispose();
        }

        private void _IdexFile(string path)
        {
            FileInfo file = new FileInfo(path);
            Document document = new Document();

            Field content = new Field(Constants.CONTENTS, new StreamReader(file.FullName));
            Field fileName = new Field(Constants.FILE_NAME, file.Name, Field.Store.YES, Field.Index.NOT_ANALYZED);
            Field filePath = new Field(Constants.FILE_PATH, file.FullName, Field.Store.YES, Field.Index.NOT_ANALYZED);

            document.Add(content);
            document.Add(fileName);
            document.Add(filePath);

            this.writer.AddDocument(document);
        }
    }
}
