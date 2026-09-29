using Microsoft.EntityFrameworkCore;
using MimosiGeCore.Domain.Models;

namespace MimosiGeCore.Application.Abstractions;

/// <summary>
///     სასწავლო ცენტრის ბაზის აბსტრაქცია. აპლიკაციის ფენა (რეპოზიტორიები) კონკრეტულ DbContext-ს არ იცნობს,
///     მხოლოდ ამ ინტერფეისს. რეალიზაცია MimosiGeDbPart-ის MimosiGeDbContext-ია
/// </summary>
public interface IMimosiGeDbContext
{
    DbSet<AcademicYear> AcademicYears { get; }
    DbSet<BankAccount> BankAccounts { get; }
    DbSet<Course> Courses { get; }
    DbSet<CrmAnswerType> CrmAnswerTypes { get; }
    DbSet<CrmCallType> CrmCallTypes { get; }
    DbSet<CrmCall> CrmCalls { get; }
    DbSet<ErrorLogText> ErrorLogTexts { get; }
    DbSet<GeoMonth> GeoMonths { get; }
    DbSet<GroupDayTimePlace> GroupDayTimePlaces { get; }
    DbSet<GroupSize> GroupSizes { get; }
    DbSet<Group> Groups { get; }
    DbSet<GroupByStudent> GroupsByStudents { get; }
    DbSet<GroupByTeacher> GroupsByTeachers { get; }
    DbSet<Human> Humans { get; }
    DbSet<LessonStatus> LessonStatuses { get; }
    DbSet<Lesson> Lessons { get; }
    DbSet<LessonByStudent> LessonsByStudents { get; }
    DbSet<LessonCheckCreateErrorLog> LessonsCheckCreateErrorLogs { get; }
    DbSet<OperationMonth> OperationMonths { get; }
    DbSet<Payment> Payments { get; }
    DbSet<ReportCategory> ReportCategories { get; }
    DbSet<Report> Reports { get; }
    DbSet<ReportByCategory> ReportsByCategories { get; }
    DbSet<Room> Rooms { get; }
    DbSet<RsCountry> RsCountries { get; }
    DbSet<RsQuoteType> RsQuoteTypes { get; }
    DbSet<SalaryHeader> SalaryHeaders { get; }
    DbSet<SalaryLine> SalaryLines { get; }
    DbSet<SalaryLineDetail> SalaryLinesDetails { get; }
    DbSet<SalaryPartType> SalaryPartTypes { get; }
    DbSet<SalaryPart> SalaryParts { get; }
    DbSet<StudentContractDetail> StudentContractDetails { get; }
    DbSet<StudentContract> StudentContracts { get; }
    DbSet<StudentStatus> StudentStatuses { get; }
    DbSet<TeacherContract> TeacherContracts { get; }
    DbSet<TeacherSalaryScheme> TeacherSalarySchemes { get; }
    DbSet<LessonStartTime> LessonStartTimes { get; }
    DbSet<WeekDay> WeekDays { get; }
    DbSet<WorkHourGroup> WorkHourGroups { get; }
    DbSet<WorkHour> WorkHours { get; }
}
