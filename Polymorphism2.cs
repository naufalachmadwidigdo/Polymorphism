using System;

public class HelloWorld
{
    static public void Main ()
    {
     familyhobi ak = new familyhobi();
     familyhobi ayah = new Ayah();
     familyhobi ibu = new Ibu();
     familyhobi anak = new Anak();
     
     familydata ayahku = new familydata("Buchori",59,085852519641);
    familydata ibuku = new familydata("Maifuroh",54,085852519641);
    familydata aku = new familydata("Naufal Achmad Widigdo",16 ,081232334504);
     Console.WriteLine("data ayah:\n"+ayahku.nama+"\n"+ayahku.umur+"\n"+ayahku.nohp);
     ayah.Hobi();
   Console.WriteLine("data ibu:\n"+ibuku.nama+"\n"+ibuku.umur+"\n"+ibuku.nohp);
     ibu.Hobi();
     Console.WriteLine("data anak:\n"+aku.nama+"\n"+aku.umur+"\n"+aku.nohp);
     anak.Hobi();
     
        

    }
    class familydata
    {
        public string nama;
        public int umur;
        public long nohp;
        
        public familydata(string Nama,int Umur,long Nohp)
        {
            nama = Nama;
            umur = Umur;
            nohp = Nohp;
        }
       
        
        
    }
    class familyhobi 
    {
        public virtual void Hobi()
        {
            Console.WriteLine("Hobi");
        }
    }
    class Ayah:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Olahraga");
        }
    }
    class Ibu:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Memasak");
        }
    }
    class Anak:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Menonton film");
        }
    }
    

}
