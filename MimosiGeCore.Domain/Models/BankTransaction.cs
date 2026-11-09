using System;
using System.Collections.Generic;

namespace MimosiGeCore.Domain.Models;

/// <summary>
///     ბანკიდან ინტეგრაციით მიღებული ჩარიცხვა (D164). ქმნის მხოლოდ ბანკთან ინტეგრაცია, ბანკის უნიკალური
///     იდენტიფიკატორით; მოსწავლეებზე განაწილება გადახდებია (Payments.BankTransactionId)
/// </summary>
public sealed class BankTransaction
{
    public int Id { get; set; }

    /// <summary>
    ///     ბანკის ანგარიში, რომელზეც ჩაირიცხა
    /// </summary>
    public int BankAccountId { get; set; }

    /// <summary>
    ///     ბანკის მოძრაობის უნიკალური იდენტიფიკატორი
    /// </summary>
    public required string MovementId { get; set; }

    /// <summary>
    ///     ჩარიცხვის თარიღი
    /// </summary>
    public DateTime TransactionDate { get; set; }

    /// <summary>
    ///     ჩარიცხული თანხა
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    ///     ვალუტა
    /// </summary>
    public required string Currency { get; set; }

    /// <summary>
    ///     დანიშნულება
    /// </summary>
    public string? Purpose { get; set; }

    /// <summary>
    ///     დამატებითი ინფორმაცია
    /// </summary>
    public string? AdditionalInformation { get; set; }

    /// <summary>
    ///     დამატებითი აღწერა
    /// </summary>
    public string? AdditionalDescription { get; set; }

    /// <summary>
    ///     საბუთის ნომერი
    /// </summary>
    public string? DocumentNumber { get; set; }

    /// <summary>
    ///     გადამხდელის სახელი
    /// </summary>
    public string? PartnerName { get; set; }

    /// <summary>
    ///     გადამხდელის ანგარიში (IBAN)
    /// </summary>
    public string? PartnerAccountIban { get; set; }

    /// <summary>
    ///     გადამხდელის ბანკის კოდი
    /// </summary>
    public string? PartnerBankCode { get; set; }

    /// <summary>
    ///     გადამხდელის საიდენტიფიკაციო კოდი ან პირადი ნომერი
    /// </summary>
    public string? PartnerTaxCode { get; set; }

    /// <summary>
    ///     გადამხდელის პირადი ნომერი
    /// </summary>
    public string? PartnerPersonalNumber { get; set; }

    /// <summary>
    ///     ბანკიდან მიღების დრო
    /// </summary>
    public DateTime ImportedAt { get; set; }

    /// <summary>
    ///     რომელმა წესმა იპოვა მოსწავლე (0 = ვერ იპოვა)
    /// </summary>
    public int MatchStep { get; set; }

    /// <summary>
    ///     განაწილება მენეჯერმა ხელით გააკეთა ან შეცვალა
    /// </summary>
    public bool AllocatedManually { get; set; }

    /// <summary>
    ///     არ არის მოსწავლის გადახდა (არ ნაწილდება და რეპორტში არ ჩანს)
    /// </summary>
    public bool Ignored { get; set; }

    public BankAccount BankAccount { get; set; } = null!;

    public ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
