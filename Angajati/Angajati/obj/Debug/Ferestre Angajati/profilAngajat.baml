   M S B A M L   `   `   `  ����C  ?Angajati, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Angajati.Ferestre_AngajatiAngajati.Ferestre_Angajati  5   	   .    (Angajati.Ferestre_Angajati.profilAngajat   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Angajati.Ferestre_Angajati     5   	     � Title$  MainPage��5   	   $	��770��6   $
��1220��6'    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency . .��5      � .+�5   
   ��  �� CornerRadius$ 25��6   ��5      �� 5       �� ImageSource$ /Images/triangles.png��6   5      � 5   
    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $	��280 �6#   �� 5      $	��280 �6#   �� 5      $	��280 �6#   �� 5      $	��280 �6#   �� 5      $��* �6#    � RowDefinitions 5      �� 5      $	��140 �6    �� 5       $	��360 �6    �� 5!      $	��170 �6    �� 5"      $��70 �6    .+�5%      �� $��0��6   $��1��5&      $��2��5'      $��S C R I P T    C A F E��5(      ���#CDD7E0$��Oswald)�5*      $��36(�5+      $��	20,50,0,0q�5,      $
��Bold"�5-      	 J� Effect	 5.      3  -System.Windows.Media.Effects.DropShadowEffect  5/      51      � 53      $��3��6   $��0��54      $��6��55      $��Center=�56       57      �� 58      $��25 �6'   �� 59      $
��1170 �6'   �� 5:      $��25 �6'   .+�5=      �� $��1��6   
������ $ 	10,10,0,0��5?      $��0,0,0,0q�5@      $��Right=�5A      ._�5B      �  5C      �� 5D      $	��195 �6/   �� 5E      $	��195 �6/   �� 5F      $	��195 �6/   �� 5G      $	��195 �6/   �� 5H      $	��195 �6/   �� 5I      $	��195 �6/   .+�5O      �� -   5        
 ��Name$

 home��5P   	   $��0��5O   !   $��0,0,0,0q�5Q   	    � OverridesDefaultStyle . ��5U      �� 5V   "    �� 
TargetType" ��62   .R�5W   &   �� #��z��6-   ._�5X   *   �� $��/Images/homeicon.png��60   $��Uniform=�6N   5Y   '   5Z   #   ��5]      �� 5^   "    �� 
TargetType" ��6(   .�5_   &   ��  �� Property � �� �� Value
 ���� 6C   �� 5`   &    � �� �#182c256D   �� 5a   &    � ��$ 0q�6H    �� Triggers 5b   &   P� 5c   *    P� Property �@J�IsMouseOver P� Value . . �5d   .   ��  � �� �#182c256K   �� 5e   .    � �� �#182c256L   �� 5f   .    � ��$ 2q�6P   5g   +   P� 5h   *    � �� . . �5i   .   ��  � �� �#182c256K   5j   +   5l   #   .��5o      � $��60��6$    � HorizontalOffset$	 -12��5p       � PlacementTarget 5q      ��  �� ElementName$
 home����5r      �� $
 home�� �� Path$ IsMouseOver� �� Mode$ OneWay=�.��5t   "   � .+�5u   &   �� ���#F0F0F0 �� Padding$ 5q�6B   ._�5v   *   �� $��Acasa��64   
���   �$
��Bold"�5x      $��14(�5y      5z   '   5{   #   5}      5~      �� 5�      -   5        $
 reservation��5�      $��1��5�   !   $��0,0,0,0q�5�      $��2��6   $��	97,0,97,0q�60    . ��5�      �� 5�   "   " ��6(   .�5�   &   ��  � ��
 ���� 6C   �� 5�   &    � �� �#182c256D   �� 5�   &    � ��$ 0q�6H    5�   &   P� 5�   *    �@J�IsMouseOver . . �5�   .   ��  � �� �#182c256K   �� 5�   .    � �� �#182c256L   �� 5�   .    � ��$ 2q�6P   5�   +   P� 5�   *    � �� . . �5�   .   ��  � �� �#182c256K   5�   +   5�   #   ��5�      �� 5�   "   " ��62   .R�5�   &   �� #��z��6-   ._�5�   *   �� $��/Images/table.png��60   $��Uniform=�6K   5�   '   5�   #   .��5�      � $	��120��6$   $ -6��5�       5�      �� $ reservation����5�      �� $ reservation��$ IsMouseOver�$ OneWay=�.��5�   "   � .+�5�   &   �� ���#F0F0F0$ 5q�6B   ._�5�   *   �� $��Rezervarile tale!��64   
���   �$
��Bold"�5�      $��14(�5�      5�   '   5�   #   5�      5�      �� 5�      -   5        $
 comenzi��5�   1   $��3��6!   $��0,0,0,0q�6B   $��2��6]   $��
54,0,141,0q�6q   ��5�      �� 5�   "   " ��6(   .�5�   &   ��  � ��
 ���� 6C   �� 5�   &    � �� �#182c256D   �� 5�   &    � ��$ 0q�6H    5�   &   P� 5�   *    �@J�IsMouseOver . . �5�   .   ��  � �� �#182c256K   �� 5�   .    � �� �#182c256L   �� 5�   .    � ��$ 2q�6P   5�   +   P� 5�   *    � �� . . �5�   .   ��  � �� �#182c256K   5�   +   5�   #   ��5�      �� 5�   "   " ��62   .R�5�   &   �� #��z��6-   ._�5�   *   �� $��/Images/coffee-cup.png��60   $��Uniform=�6P   5�   '   5�   #   .��5�      � $	��120��6$   $ -6��5�       5�      �� $ comenzi����5�      �� $ comenzi��$ IsMouseOver�$ OneWay=�.��5�   "   � .+�5�   &   �� ���#F0F0F0$ 5q�6B   ._�5�   *   �� $��Comenzi!��64   
���   �$
��Bold"�5�      $��14(�5�      5�   '   5�   #   5�      5�      �� 5�      -   5        $
 aboutus��5�      $��5��5�   !   
������ $��0,0,0,0q�5�      $��0q�5�      ��5�      �� 5�   "   " ��6(   .�5�   &   ��  � ��
 ���� 6C   �� 5�   &    � �� �#182c256D   �� 5�   &    � ��$ 0q�6H    5�   &   P� 5�   *    �@J�IsMouseOver . . �5�   .   ��  � �� �#182c256K   �� 5�   .    � �� �#182c256L   �� 5�   .    � ��$ 2q�6P   5�   +   P� 5�   *    � �� . . �5�   .   ��  � �� �#182c256K   5�   +   5�   #   ��5�      �� 5�   "   " ��62   .R�5�   &   �� #��z��6-   ._�5�   *   �� $��/Images/phone-call.png��60   $��Uniform=�6P   5�   '   5�   #   .��5     � $��85��6$   $	 -19��5      J� Opacity$ 0Q�5  N   $y�Hidden=�6Z    5     �� $ aboutus����5     �� $ aboutus��$ IsMouseOver�$ OneWay=�.��5  "   � .+�5	  &   �� ���#F0F0F0$ 5q�6B   ._�5
  *   �� $��
Despre noi��64   
���   �$
��Bold"�5     $��14(�5     5  '   5  #   5     5     5     5     5     5     � 5  
   $��1��6   $��2��5     $��2��5     $��Center=�5     $��Center=�5     $��	0,-30,0,0q�5      .+�5"     A� $��-140,-301,-96,45q�6   ��5#     �� 5$     $ /Images/user.png��6!    j� Stretch$ UniformToFill=�6@   5&     5'     �� 5*  
   $��3��6   $��
50,350,0,0q�6"   $
��Left=�66   .+�5+     ��  �� Orientation$ 
Horizontal=�6   $
��0 10q�62   $��50��6@   .+�5,     �� $��Segoe MDL2 Assets)�6   $	����6;   $��50(�6D   
�������6R   �� 50     -   5         ��Name$ Nume_Prenume��50     $
��15 0q�62   $��40(�6@   
�������$��60��6`   $	��782��6l   
������ 6x   52     �� 54     $ 
Horizontal=�6   $
��0 10q�62   .+�55     �� $��Segoe MDL2 Assets)�6   $	����6;   $��50(�6D   
�������6R   �� 56     -   5        $ Email��56     $
��15 0q�6+   $��40(�69   
�������$��60��6Y   $	��782��6e   
������ 6q   57     �� 59     $ 
Horizontal=�6   $
��0 10q�62   .+�5:     �� $��Segoe MDL2 Assets)�6   $	����6;   $��50(�6D   
�������6R   �� 5;     -   5        $	 Rol��5;  �   $��10 -10 5 10q�6   $��45(�61   
�������$	��782��6Q   $��60��6]   
������ 6�   5<     5=     � 5B  
   $��50��6   $��50��5C     $��Right=�5D     $	��Top=�5E     $��	0,30,73,0q�5F     .+�5G     �� -   5        $

 user��5G     $��0,0,0,0q�6#   $��50��6P   $	��Top=�6\   ��5H     �� 5I     " ��6   .�5J     ��  � ��
 ���� 67   �� 5K      � �� �#182c2568   �� 5L      � ��$ 0q�6<    5M     P� 5N      �@J�IsMouseOver . . �5O  "   ��  � �� �#182c256?   �� 5P  "    � �� �#182c256@   �� 5Q  "    � ��$ 2q�6D   5R     P� 5S      � �� . . �5T  "   ��  � �� �#182c256?   5U     5W     ��5Y     �� 5Z     " ��6&   .R�5[     �� #��z��6!   ._�5]     �� $��/Images/profile-user.png��6$   $��Uniform=�6F   5^     5_     5d     5f     �� 5g  
   -	   5        $
 logoutButton��5g     $��0,0,0,0q�5h     $
��Left=�6   $��83��66   $��1082,116,0,0q�6B   $	��Top=�6X   $	��120��6p   ��5i     �� 5j     " ��6   .�5k     ��  � ��
 ���� 63   �� 5l      � �� �#182c2564   �� 5m      � ��$ 0q�68    5n     P� 5o      �@J�IsMouseOver . . �5p     ��  � �� �#182c256;   �� 5q      � �� �#182c256<   �� 5r      � ��$ 2q�6@   5s     P� 5t      � �� . . �5u     ��  � �� �#182c256;   5v     5x     ��5z     �� 5{     " ��6"   .R�5|     �� #��z��6   ._�5~     �� $��/Images/logout.png��6    $��Uniform=�6<   5     5�     5�     � 5�  
   $��50��6   $	��Top=�5�     $��1160,30,0,0q�5�     $
��Left=�5�     $��50��5�     .+�5�     �� -
   5        $
 ExitBtn��5�     $��0,0,0,0q�5�     $��Center=�6   $��50��68   $��50��6Y   $	��Top=�6e   ��5�     �� 5�     " ��6   .�5�     ��  � ��
 ���� 67   �� 5�      � �� �#182c2568   �� 5�      � ��$ 0q�6<    5�     P� 5�      �@J�IsMouseOver . . �5�  "   ��  � �� �#182c256?   �� 5�  "    � �� �#182c256@   �� 5�  "    � ��$ 2q�6D   5�     P� 5�      � �� . . �5�  "   ��  � �� �#182c256?   5�     5�     ��5�     �� 5�     " ��6&   .R�5�     �� #��z��6!   ._�5�     �� $��/Images/close.png��6$   $��Uniform=�6?   5�     5�     5�     5�     5�     5�     