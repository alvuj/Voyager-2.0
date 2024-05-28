# Voyager 2.0

Voyager 2.0 je side-scroller shooter igra razvijena u C# koristeći Windows Forms. Igra omogućava igračima da kontroliraju svemirski brod i bore se protiv neprijatelja dok napreduju kroz razine.

## Sadržaj

- [Instalacija](#instalacija)
- [Korištenje](#korištenje)
- [Struktura Projekta](#struktura-projekta)
- [Licenca](#licenca)

## Instalacija

1. Klonirajte repozitorij:
    ```bash
    git clone https://github.com/alvuj/voyager-2.0.git
    ```
2. Otvorite projekt u Visual Studio-u.
3. Izgradite rješenje da biste instalirali sve potrebne zavisnosti.

## Korištenje

1. Pokrenite aplikaciju iz Visual Studio-a.
2. Na početnom ekranu odaberite "Start" za početak igre.
3. Koristite tipke sa strelicama za kretanje i razmaknicu za pucanje.
4. Cilj igre je uništiti što više neprijatelja i postići visok rezultat.

## Struktura Projekta

- `Voyager/Voyager/Form1.cs`: Glavni formular igre. Sadrži logiku za kretanje svemirskog broda, pucanje i interakciju s neprijateljima.
- `Voyager/Voyager/Properties/Resources.Designer.cs`: Upravljanje resursima igre, kao što su slike pozadine i spriteovi.
- `Voyager/Voyager/StartScreen.resx`: Resursi za početni ekran igre.
- `Voyager/Voyager/name.cs`: Formular za unos imena igrača.
- `Voyager/Voyager/score.cs`: Formular za prikaz rezultata.
- `Voyager/Voyager/Properties/Settings.settings`: Postavke aplikacije.

## Licenca

Ovaj projekt je licenciran pod MIT licencom. Pogledajte [LICENSE](LICENSE) fajl za više informacija.
