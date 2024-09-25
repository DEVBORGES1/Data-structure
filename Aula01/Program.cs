using Aula01;

int number;

//Atribui valor
number = 10;

//Declarando constante
const int DAYS_IN_WEEK = 7;

// Imprimindo string concatenada
Console.WriteLine( $"A semana tem {DAYS_IN_WEEK} dias. ");

// new TipoEnumerador() -> Invoca o metodo controladoe do objeto
// Toda classe tem seu construtor padrao implíncito sem argumentos/paramentros
// É possível sobreescrever este metodo especificando argumento
// Todavia, se o fizermos, perdemos o original implicito e
//precisaremos definilo explicitamente
TipoEnumerador tipoEnum = new TipoEnumerador();
TipoEnumerador.Language enumEnglish  = tipoEnum.GetLanguageEnum("inglês");
Console.WriteLine( $"O enum de inglês é (enumEnglish)" );