using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiziWorks : MonoBehaviour
{
    public int sayi = 5;
    int sonuc=1;
    string metin="sarý";
   // string sonuc;
    // Start is called before the first frame update
    void Start()
    {
        // faktöriyel hesabý
        for (int i = sayi; i >0; i--)
        {
            sonuc = sonuc * i ;
            
        }
        Debug.Log(sonuc);

        
        
        //girilen metni tersten yazdýrma
        for (int i = metin.Length - 1; i >= 0; i--)
        {
            sonuc += metin[i];
            
        }
        Debug.Log(sonuc);
    }

    // Update is called once per frame
    void Update()
    {

       
    }
    /*public void dizi()
    {
        foreach (var item in sayilar)
        {
            
        }
    }*/

}
