// Checked Uncheckd

/* O procedimento de Cast é uma operação que permite alterar o Tipo de um Dado (Uma variável possui um Tipo, Nome e Valor ou Referência).
 * Por exemplo:*/

int i = 100;

long l = i;

/* Acima temos um Cast implícito sem perda de dados. Não ocorre a parda de dados porque o Tipo Long é mais abrangente do que o Tipo Int. */

double a = 1.5;

int b = (int)a;

/* Acima temos um Cast explícito com perda de dados. O Tipo Double é mais abrangente em comparação ao Tipo Int, portanto a operação será ralizada com a parde de informação
 * Teremos como resultado o valor 1. */

byte b1 = 100;

byte b2 = 200;

byte b3 = (byte)(b1 + b2);

/* Acima nós temos um Cast explícito com perda de dados, porém este é um caso bem específico, porque teremos armazenado na variável b3 um valor "estranho"
 * inconsistente Sabemnos que um byte pode armazenar um valor de 0 a 255, como temos um valor total da soma de 300, será armazenado o valor 44 na variável b3.
 * Para evitar este tipo de operação estranha utilizamos o bloco de código checked, assim não teremos está operação, teremos o lançamento de uma 
 * exceção do tipo Overflow Exception (Sytem.OverflowException). */

checked
{
    byte b_1 = 100;

    byte b_2 = 200;

    byte b_3 = (byte)(b_1 + b_2);
}

/* Porém atenção, a checagem é realizada em tempo de execução, então o ideal é utilizar este tipo de checagem apenas em ambientes de desenvolvimento 
 * e testes, porque está rotina vai pesar a aplicação. */

/* O Visual Studio possui um recurso que permite ativar a checagem de todo o código durante o tempo de execução, porém as vezes é necessário em alguma 
 * parte do código desativar a checagem e para isto existe o comando unchecked. */

unchecked
{
    byte b_4 = 100;

    byte b_5 = 200;

    byte b_6 = (byte)(b_4 + b_5);
}








