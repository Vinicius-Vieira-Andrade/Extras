namespace fixação_calculadora_poo
{
    public class Calculadora
    {
        //PROPRIEDADES
        public float n1;

        public float n2;

        //FUNCOES/METODOSO
        public float Somar()
        {
            return this.n1 + this.n2;     //this. = acessar propriedade de uma classe   ALGUMAS LINGUAGENS NÃO FUNCIONAM OUTRAS SIM
        }

        public float Subtrair()
        {
            return this.n1 - this.n2;
        }

        public float Multiplicar()
        {
            return this.n1 * this.n2;
        }

        public float Dividir()
        {
            return this.n1 / this.n2;
        }
    }
}