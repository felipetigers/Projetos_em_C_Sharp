namespace CSharpBasico
{
    class Quadrado  //classe quadrado
    {
        float _Lado;    //underline para distinguir o atributo com a propriedade

        public float Lado       //Lado é a propriedade do atributo _Lado
        {
            set { _Lado = value; }      //setter
            get { return _Lado; }        //getter
        }

        public float Perimetro()    //visibilidade pública para que o método seja acessível fora da classe
        {
            return 4 * Lado;    
        }

    }
}
