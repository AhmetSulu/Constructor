using Constructor;

// Default constructor ile nesne oluşturma
Baby bebek1 = new Baby();
Console.WriteLine("Bebek 1:");
Console.WriteLine($"Ad: {bebek1.Name} \nSoyad: {bebek1.Surname} \nDoğum Tarihi: {bebek1.BirthDay} ");

// Ad ve Soyad parametrelerini alan constructor ile nesne oluşturma
Baby bebek2 = new Baby("Muhammed Hamza", "Yuyucu");
Console.WriteLine("\nBebek 2:");
Console.WriteLine($"Ad: {bebek2.Name} \nSoyad: {bebek2.Surname} \nDoğum Tarihi: {bebek2.BirthDay}");