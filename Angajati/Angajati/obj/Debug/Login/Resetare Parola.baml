   M S B A M L   `   `   `  ����C  ?Angajati, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Angajati.LoginAngajati.Login  5   	   $    Angajati.Login.Resetare_Parola   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Angajati.Login     5   	     � Title$  Resetare_Parola��5   	   $	��770��6!   $
��1220��6.   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��1.5* �6   .+�5   
   ��  �� CornerRadius$ 	10 0 0 10��6   ��5      �� 5       �� ImageSource$ /Images/triangles.png��6    j� Stretch$ UniformToFill=�6A   5      � 5   
   .+�5      �� $��Center=�6   .+�5      �� $��Ați uitat parola?��6      titleTextBlack#��[  65   
������� J� RenderTransformOrigin$ 0.511,3.865&�6p   $��53��6�   �� 5      -   5        $
��Back��5       
 button#��[ 5      
�������$	��132��5      $��50��6   $ 	10,20.568&�5      $��
0,420,0,20q�5      6!   5      5      �� 5    
   ���#ffffff$��1��6&   $ 	0 10 10 0��66   ._�5!      �� $��Center=�6   .+�5"      �� $��Introduceți token-ul!��6     	titleText#��[ 5#      ���#0f23105$      �� 5%      $>��8Introduceți token-ul primit de dumneavoastră pe email!��6     
normalText#��[ 6Z   ���#878787$��	0 10 0 15q�6�   �� 5&      $��1q�6   ���#acb0af$
��70 7q�6C   $ 10��6Q   ._�5'      � $	��7 9q�6    5(      �� 5)      $
��auto �6/   �� 5*      $	��33* �6/   �� 5+      $	��95* �6/   .+�5-      �� -   5         ��Name$ 	textToken��5-   $   $��Token��5.        textHint#��[ 5/      $��1��50      $��2��6$   $��10,0,0,0q�68   �� 51      -   5         ��Name$ txtToken��51   "     textBox#��[ 52      $��1��53      $��10,0,0,0q�54       �� 	MaxLength$ 6��6$   $��2��62   55      56      �� 57      -   5        $��Validează!��57        
mainbutton#��[ 59   	   $��
70,20,70,0q�5:   	   $��Center=�6   6:   5;      5<      5>      5?      