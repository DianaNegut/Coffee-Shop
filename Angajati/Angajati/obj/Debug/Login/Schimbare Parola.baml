   M S B A M L   `   `   `  ����C  ?Angajati, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Angajati.LoginAngajati.Login  5   	   %    Angajati.Login.Schimbare_Parola   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Angajati.Login     5   	     � Title$  Schimbare_Parola��5   	   $	��770��6"   $
��1220��6/   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��1.5* �6   .+�5   
   ��  �� CornerRadius$ 	10 0 0 10��6   ��5      �� 5       �� ImageSource$ /Images/triangles.png��6    j� Stretch$ UniformToFill=�6A   5      � 5   
   .+�5      �� $��Center=�6   .+�5      �� $��Ați uitat parola?��6   
�������   titleTextBlack#��[  6H    J� RenderTransformOrigin$ 0.511,3.865&�6p   $��53��6�   �� 5      -   5        $
��Back��5       
 button#��[ 5      
�������$	��132��5      $��50��6!   $ 	10,20.568&�5      $��
0,420,0,20q�5      6)   5      5      �� 5    
   ���#ffffff$��1��6&   $ 	0 10 10 0��66   ._�5!      �� $��Center=�6   .+�5"      �� $��Introduceți noua parola!��6     	titleText#��[ 5#      ���#0f23105$      �� 5%      $��1q�6   ���#acb0af$
��70 7q�6C   $ 10��6Q   $��50��6c   ._�5&      � $	��7 9q�6    5'      �� 5(      $
��auto �6/   �� 5)      $��* �6/   .+�5+      �� $��0��6$   $��0��61   $��Parola:��6A   $��Center=�6P   $��5q�6k   �� 5,      -   5         ��Name$ textPassword��5,   "     textBox#��[ 68   $��1��6Y   $��
75,0,100,0q�6i   G� 5-      -   5         G�Name$ txtPassword��5-   &     passwordBox#��[ 6;   $��1��6`   $��
75,0,100,0q�6p   �� 5.      -   5        $ txtPasswordVisible��5.   "   #��[ 6>   $��1��6_   $��
75,0,100,0q�6o   $y�	Collapsed=�6�   �� 5/      -   5         ��Name$ showPasswordCheckBox��5/   :   $��Arată parola��6#   $��1��51      $��Center=�6)   $��Right=�6D   $��0, 0, 10, 0q�6`   52      53      �� 55      $��1q�6   ���#acb0af$
��70 7q�6C   $ 10��6Q   $��50��6c   ._�56      � $	��7 9q�6    57      �� 58      $
��auto �6/   �� 59      $��* �6/   .+�5;      �� $��0��6$   $��0��61   $��Reintroduceți parola:��6A   $��Center=�6^   $��5q�6y   �� 5<      -   5        $ textPassword2��5<   "   #��[ 69   $��1��6Z   $��
75,0,100,0q�6j   G� 5=      -   5        $ txtPassword2��5=   &   #��[ 6<   $��1��6a   $��
10,0,100,0q�6q   �� 5>      -   5        $ txtPasswordVisible2��5>   "   #��[ 6?   $��1��6`   $��
10,0,100,0q�6p   $y�	Collapsed=�6�   �� 5?      -	   5        $ showPasswordCheckBox2��5?   :   $��Arată parola��6#   $��1��5A      $��Center=�6)   $��Right=�6D   $��0, 0, 10, 0q�6`   5B      5C      �� 5G      -
   5        $��Validează!��5G        
mainbutton#��[ 5H      $��
70,20,70,0q�5I      $��Center=�6)   6F   5J      5K      5M      5N      