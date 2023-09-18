using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Course
{
    public static class Storage
    {
        public static List<Models.Number> Numbers { get; set; } = new List<Models.Number>() 
        {
            // Номера люкс
            new Models.Luxe("luxe0", "Номер люкс", 15000, new Random().Next(5)),
            new Models.Luxe("luxe1", "Номер люкс", 15000, new Random().Next(5)),
            new Models.Luxe("luxe2", "Номер люкс", 15000, new Random().Next(5)),
            new Models.Luxe("luxe3", "Номер люкс", 15000, new Random().Next(5)),
            new Models.Luxe("luxe4", "Номер люкс", 15000, new Random().Next(5)),
            // Номера полулюкс
            new Models.SemiLuxe("semiLuxe0", "Номер люкс", 10000, "Доп. чесалки для спины"),
            new Models.SemiLuxe("semiLuxe1", "Номер люкс", 10000, "Доп. полотенца"),
            new Models.SemiLuxe("semiLuxe2", "Номер люкс", 10000, "Доп. мыло"),
            new Models.SemiLuxe("semiLuxe3", "Номер люкс", 10000, "Доп. балкон"),
            new Models.SemiLuxe("semiLuxe4", "Номер люкс", 10000, "Доп. лоджия"),
            // Номера однокомнатные
            new Models.SingleRoom("singleRoom0", "Номер одноместный", 5000, 1),
            new Models.SingleRoom("singleRoom1", "Номер одноместный", 5000, 2),
            new Models.SingleRoom("singleRoom2", "Номер одноместный", 5000, 1),
            new Models.SingleRoom("singleRoom3", "Номер одноместный", 5000, 1),
            new Models.SingleRoom("singleRoom4", "Номер одноместный", 5000, 2),
            // Номера двукомнатные
            new Models.DoubleRoom("doubleRoom0", "Номер двуместный", 7000, 4),
            new Models.DoubleRoom("doubleRoom1", "Номер двуместный", 7000, 3),
            new Models.DoubleRoom("doubleRoom2", "Номер двуместный", 7000, 2),
            new Models.DoubleRoom("doubleRoom3", "Номер двуместный", 7000, 5),
            new Models.DoubleRoom("doubleRoom4", "Номер двуместный", 7000, 6),
            // Номера двушки с диванами
            new Models.RoomWithSofa("sofaRoom0", "Номер с диванами", 8000, 3, 3),
            new Models.RoomWithSofa("sofaRoom1", "Номер с диванами", 8000, 3, 3),
            new Models.RoomWithSofa("sofaRoom2", "Номер с диванами", 8000, 3, 3),
            new Models.RoomWithSofa("sofaRoom3", "Номер с диванами", 8000, 3, 3),
            new Models.RoomWithSofa("sofaRoom4", "Номер с диванами", 8000, 3, 3)
        };

        public static List<Models.Request> Requests { get; set; } = new List<Models.Request>();
    }
}
