// Ekrandan girilen bir ifadeyi aşağıdaki yöntemle şifreleyen ve oluşan şifreyi ekranda gösteren programı yazınız.
//             NOT : Ekrandan girilen ifadede Türkçe karakter olabilsin

//             Örneğin, ekrandan "ali" girilmiş olsun
//             * her karakterin ascii kodu bulunur
//                a --> 97     --> int
//                l --> 108    --> int
//                i --> 105    --> int
//             * bulunan bu ascii kodlar başlarına yeteri kadar 0 eklenerek 4 haneli getilrir ve yanyana birleştirilir : 
//              a --> "0097"
//              l --> "0108"
//              i --> "0105"
//              yanYana --> "009701080105" 
//             * Bu yanyana gelmiş ifadeden TEK SEFERDE 1 karakter baştan 1 karakter sondan (Baştaki 0 ve sondaki 5 daha sonra, baştan 2. olan 0 ve sondan 2. olan 0 şeklinde devam edecek) alınıp birleştirilmek suretiyle şifre elde edilir : 
//             sifre --> "050091700810"

            Console.Write("Şifrelenecek ifadeyi giriniz : ");
            string ifade = Console.ReadLine(); 

            ifade = ifade.Replace('ç', 'c');
            ifade = ifade.Replace('Ç', 'C');
            ifade = ifade.Replace('ğ', 'g');
            ifade = ifade.Replace('Ğ', 'G');
            ifade = ifade.Replace('ı', 'i');
            ifade = ifade.Replace('İ', 'I');
            ifade = ifade.Replace('ö', 'o');
            ifade = ifade.Replace('Ö', 'O');
            ifade = ifade.Replace('ş', 's');
            ifade = ifade.Replace('Ş', 'S');
            ifade = ifade.Replace('ü', 'u');
            ifade = ifade.Replace('Ü', 'U');


            string asciilerYanYana = "";
            string sifre = "";

            for (int i = 0; i < ifade.Length; i++)
            {
               string ascii = Convert.ToInt32(ifade[i]).ToString();
               if (ascii.Length == 2)
                   ascii = "00" + ascii;
               else
                   ascii = "0" + ascii;

               asciilerYanYana += ascii;
            }

            for (int i = 0; i < asciilerYanYana.Length / 2; i++)
            {
               sifre += asciilerYanYana[i];
               sifre += asciilerYanYana[asciilerYanYana.Length - 1 - i];
            }

            Console.WriteLine($"{ifade}'nin şifresi : {sifre}");

            Console.ReadLine();
