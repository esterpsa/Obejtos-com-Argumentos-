namespace Objetos_com_Argumentos.classes
{
    public class Produto
    {
        public int Codigo {get; set;}

        public string Nome {get; set;}

        public float Preco {get; set;}

        public Produto(){

        }

        public Produto(int _coodigo, string _nome, float _preco){
            this.Codigo = _coodigo;
            this.Nome = _nome;
            this.Preco = _preco;
        }
    }
}