   M S B A M L   `   `   `  ����C  ?Angajati, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Angajati.Ferestre_AngajatiAngajati.Ferestre_Angajati  5   	   -    'Angajati.Ferestre_Angajati.Icon_Comanda   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Angajati.Ferestre_Angajati     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	   
������  � AllowsTransparency .  � Title$ Icon_Comanda��5   	   $	��450��6   $	��450��6+   .��5      � .+�5   
   ��  �� CornerRadius$ 25��6   $	��450��6#   $��Center=�60   $
��Left=�6K   $	��450��6f   ��5      �� 5       �� ImageSource$ /Images/gold.jpg��6   ._�5      � $��Center=�6   $��23��60   $��0,42,0,0q�6<   $	��Top=�6N   $	��409��6f   5      �� 5   
   -   5         ��Name$ Nume_Client��5      
������ $
��Left=�6@   $��20��6[   $��
155,73,0,0q�6g    �� TextWrapping$
 Wrap=�5      $�� ��6&   	 �� 
IsReadOnly	 . $	��Top=�6@   $	��150��6X   
���   �$
��Bold"�5   
   �� 5   
   $
��Left=�6   $��19��6/   $��15(�6;   $
��Wrap=�6I   $��Nume Client:��6]   $	��Top=�6q   $	��110��6�   $��	23,72,0,0q�6�   �� 5   
   -   5        $
 Data��5      $
��Left=�6    
������ $��20��6T   $��
155,97,0,0q�6`   $
 Wrap=�5      $�� ��6&   	 . $	��Top=�6@   $	��140��6X   
 J� RenderTransformOrigin$
 0.526,1.158&�6d   
���   �$
��Bold"�5    
   �� 5"   
   $
��Left=�6   $��19��6/   $
��Wrap=�6;   $��Data:��6O   $��15(�6\   $	��Top=�6j   $��89��6�   $��	23,98,0,0q�6�   �� 5%   
   $
��Left=�6   $��20��6/   $
��Wrap=�6;   $��15(�6O   $��Conținut comandă:��6]   $	��Top=�6v   $	��137��6�   $��
23,127,0,0q�6�   �� 5'   
   -   5        $ Numar_Comanda��5'      $
��Left=�6)   
������ $��20��6]   $��
165,43,0,0q�6i   $
 Wrap=�5(   
   $�� ��6   	 . $	��Top=�68   $	��140��6P   $
 0.526,1.158&�6\   
���   �$
��Bold"�5)      �� 5*   
   $
��Left=�6   $��18��6/   $��5,43,0,0q�6;   $��14(�6M   $
��Wrap=�6[      	titleText#��[  6o   $��NUMĂR COMANDĂ:��6�   
���   �$
��Bold"�5,   
   $	��Top=�6   $	��170��64   � 5.   
   $��150,132,20,78q�6    � ColumnDefinitions 5/      �� 50      $��0* �6#   �� 51      �� 52      $	��28* �6#   .+�55      ��  �� Orientation$ 
Horizontal=�6   $��2,0,0,5q�62   $��2��6C   .+�56      �� $��  Nume��6   $
��Bold"�6*   $��80��6<   $��14(�6G   �� 57      $��	Cantitate��6   $
��Bold"�6-   $��60��6?   $��14(�6J   �� 58      $��        Preț��6   $
��Bold"�60   $��80��6B   $��14(�6M   59      �� 5<      -   5         ��Name$ ListViewProduse��5<      
������ $��0q�6I   $��	4,25,13,0q�6]   $	��234��5=   :   $��2��6F   ��6   �� *ComenziDisponibile+��5>      �� 5?      .R�5@      �� $ 
Horizontal=�6%   .+�5A      �� $��14(�6C   $	��100��6Q   $��0,0,10,0q�6]   ��6(   �� *	NumeCafea+6]   �� 5B      $��14(�6C   $��60��6Q   $��0,0,10,0q�6\   ��6(   �� *	Cantitate+6\   �� 5C      $��14(�6>   $��60��6L   ��6(   �� *Pret+6L   5D      5E      5G      5H      � 5M   
   $��30��6   $	��Top=�6   $��
360,15,0,0q�63   $
��Left=�6G   $��50��6b   .+�5N      �� -   5         ��Name$ ExitBtn��5N      $��0,0,0,0q�6&   $��Center=�6@   $��68��6]   $
 0.686,0.633&�6~   ��5O      �� 5P      $ /Images/close.png��6!    j� Stretch$ Uniform=�6A   5R      5S      �� 5U   
   -   5        $��Finalizată!��5U        comandabutton#��[ 6'   $��165,390,175,10q�6N   6f   �� 5V   
   $��10,197,284,63q�6   $#��/Images/comanda_terminata.png��6'   5W      5X      