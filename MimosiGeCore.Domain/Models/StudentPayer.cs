namespace MimosiGeCore.Domain.Models;

/// <summary>
///     მოსწავლის გადამხდელი, ბანკის ჩარიცხვიდან დასწავლილი (D162, D169): მენეჯერის ხელით განაწილებისას ჩარიცხვის
///     გადამხდელი ებმება მოსწავლეს, ვისზეც თანხა გაანაწილა. მოსწავლეს რამდენიმე გადამხდელი შეიძლება ჰყავდეს, გადამხდელს
///     რამდენიმე მოსწავლე (და-ძმა)
/// </summary>
public sealed class StudentPayer
{
    public int Id { get; set; }

    /// <summary>
    ///     მოსწავლე
    /// </summary>
    public int StudentHumanId { get; set; }

    /// <summary>
    ///     გადამხდელის პირადი ნომერი
    /// </summary>
    public string? PersonalNumber { get; set; }

    /// <summary>
    ///     გადამხდელის ანგარიში (IBAN)
    /// </summary>
    public string? AccountIban { get; set; }

    /// <summary>
    ///     გადამხდელის სახელი ბანკის ჩარიცხვიდან
    /// </summary>
    public string? PayerName { get; set; }

    public Human StudentHuman { get; set; } = null!;
}
