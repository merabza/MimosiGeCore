using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using BackendCarcass.Domain;

namespace MimosiGeCore.Domain.Models;

public sealed class Room : IDataType
{
    public string RoomName { get; set; } = null!;

    public ICollection<GroupDayTimePlace> GroupDayTimePlaces { get; set; } = new List<GroupDayTimePlace>();
    public int Id { get; set; }

    [NotMapped] public string? Key => null;

    [NotMapped] public string Name => RoomName;

    [NotMapped] public int? ParentId => null;

    public bool UpdateTo(IDataType data)
    {
        if (data is not Room other)
        {
            return false;
        }

        RoomName = other.RoomName;
        return true;
    }

    public dynamic EditFields()
    {
        return new Room { Id = Id, RoomName = RoomName };
    }
}
