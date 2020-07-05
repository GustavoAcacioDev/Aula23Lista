namespace Aula23ListaObjeto
{
    public class Produto
    {
        
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        public Produto(){

        }

        /// <summary>
        /// Cadastra as características Nome, Codigo e Preço no metodo Produto
        /// </summary>
        /// <param name="_codigo"></param>
        /// <param name="_nome"></param>
        /// <param name="_preco"></param>
        public Produto(int _codigo, string _nome, float _preco)
        {
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Preco = _preco;
        }
    }
}