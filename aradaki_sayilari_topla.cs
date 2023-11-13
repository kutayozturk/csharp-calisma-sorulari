#region // iki sayi arasında kalan sayıları toplayan program

Console.WriteLine("İki Sayı Giriniz: ");
int s1=Convert.ToInt32(Console.ReadLine());
int s2=Convert.ToInt32(Console.ReadLine());
int toplam=0;

if(s1==s2){ // sayi1 ile sayi2 eşit mi?
        Console.WriteLine("Girilen Değerler Aynı");
}
else{
    if(s2==s1+1){
        Console.WriteLine("Girilen iki değer arasında başka bir değer yer almamaktadır.");
    }
    else if(s1==s2+1){
        Console.WriteLine("Girilen iki değer arasında başka bir değer yer almamaktadır.");
    }
        else if(s2>s1){
            for(int i=s1+1; i<s2; i++){
                toplam+=i;
                }
                    Console.WriteLine("Toplam = {0}",toplam);
            }
            else{ // sayi1 sayi2'den büyükse
                for(int i=s2+1; i<s1; i++){
                    toplam+=i;
                    }
                    Console.WriteLine("Toplam = {0}",toplam);
        }
    
}
#endregion
