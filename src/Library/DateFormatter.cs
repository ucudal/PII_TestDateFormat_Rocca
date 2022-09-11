namespace TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "c".</returns>
    public static string ChangeFormat(string date)
    {
        if (date.Length != 10 || date.Substring(2,1) != "/" || date.Substring(5,1) != "/")
        {
            return date="La fecha ingresada no es válida, el formato debe ser de la forma dd/mm/yyyy";
        }
        else 
        {
            return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
        }
    }
}
