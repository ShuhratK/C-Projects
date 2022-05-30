using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite USBFlashDrive = new Composite();
            USBFlashDrive.add(new Leaf("флэш память USB 1 шт. "));

            Composite Camera = new Composite();
            Camera.add(new Component[]{ new Leaf("фотоаппарат Sony"), new Leaf("футляр"), new Leaf("ремешок"), new Leaf("флэш память для фотоаппарата"),
            new Composite{children = {new Leaf("Адаптер"), new Leaf("Кабель") } } });

            Composite DellPhone = new Composite();
            DellPhone.add(new Component[] { new Leaf("телефон Dell"), new Leaf("зарядное устройство"), new Leaf("кабель"), new Leaf("наушник") });

            Composite[] catalog = new Composite[] { USBFlashDrive, Camera, DellPhone };

            foreach (var item in catalog)
            {
                Console.WriteLine(item.getName());
            }
        }
    }
}
