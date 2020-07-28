namespace Exemplo_Orientação_a_objeto
{
    //Super Classe ou  Classe pai/mãe
    public class Pessoa
    {
        //Propriedades
        protected int id;
        protected string nome;
        protected string rg;
        protected string cpf;

        //métodos Construtores
        //Construtor vazio
        public Pessoa()
        {
            this.id = 0;
            this.nome = "";
            this.rg = "";
            this.cpf = "";
        }
        //Construtor com parametrosm (parametrizado)
        public Pessoa(int _id, string _nome, string _rg, string _cpf)
        {
            this.id = _id;
            this.nome = _nome;
            this.rg = _rg;
            this.cpf = _cpf;
        }
        //Retorna objeto:
        public Pessoa retornaPessoa()
        {
            Pessoa obj = new Pessoa();
            obj.id = this.id;
            obj.nome = this.nome;
            obj.rg = this.rg;
            obj.cpf = this.cpf;
            return obj;
        }
        
        //Gets e Sets
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string NOME
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        public string RG
        {
            get { return this.rg; }
            set { this.rg = value; }
        }
        public string CPF
        {
            get { return this.cpf; }
            set { this.cpf = value; }
        }
     
    }
}
