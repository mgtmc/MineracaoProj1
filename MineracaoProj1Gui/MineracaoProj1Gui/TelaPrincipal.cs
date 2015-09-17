using Lucene.Net.Documents;
using Lucene.Net.Search;
using MineracaoProj1Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineracaoProj1Gui
{
    public partial class TelaPrincipal : Form
    {
        private MineracaoProj1Business.Searcher _searcher;

        public TelaPrincipal()
        {
            InitializeComponent();
            _IndexAll();
            this._searcher = new MineracaoProj1Business.Searcher();
        }

        private void _IndexAll()
        {
            // Colocar para a pessoa escolher a pasta
            Indexer indexer = new Indexer();
            string dataDirectory = @"C:\Users\Nina\Desktop\Nova pasta";
            indexer.IndexFiles(dataDirectory);
            indexer.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _ClearListView();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            _ClearListView();

            if (!string.IsNullOrEmpty(this.searchQuery.Text) && !string.IsNullOrWhiteSpace(this.searchQuery.Text))
                _Search(this.searchQuery.Text);
        }

        private void bn_search_Click(object sender, EventArgs e)
        {
            _ClearListView();

            if (!string.IsNullOrEmpty(this.searchQuery.Text) && !string.IsNullOrWhiteSpace(this.searchQuery.Text))
                _Search(this.searchQuery.Text);
        }

        private void _Search(string query)
        {
            this._searcher = new MineracaoProj1Business.Searcher();
            TopDocs hits = this._searcher.Search(query);

            foreach (ScoreDoc scoreDoc in hits.ScoreDocs)
            {
                Document doc = this._searcher.GetDocument(scoreDoc);
                this.listViewResult.Items.Add(doc.Get(Constants.FILE_NAME));
            }

            this._searcher.Close();
        }

        private void _ClearListView()
        {
            this.listViewResult.Clear();
            this.listViewResult.Columns.Add("Resultados", 775);
        }
    }
}
