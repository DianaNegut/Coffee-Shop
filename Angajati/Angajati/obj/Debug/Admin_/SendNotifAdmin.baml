   M S B A M L   `   `   `  ����C  ?Angajati, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AngajatiAngajati  5   	       Angajati.SendNotifAdmin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Angajati     5   	     � Title$  SendNotifAdmin��5   	   $	��770��6    $
��1220��6-    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � 	Resources 5       �� 
TargetType �� Property �� Value	 �� 
TargetType
 ��Name��%,  '��       �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      "	 ��6&   .R�5      �� $
 Border��6!   
������ #��z��5      #��z��5      ._�5      �� $��2q�6/   $��Center=�5      $��Center=�5      ��. 5      5      5      5      5       5!      .��5$      � .+�5(   
   ��  �� CornerRadius$ 25��5)      ��5*      �� 5+       �� ImageSource$ ../Images/triangles.png��6   5-      � 51   
    � ColumnDefinitions 52      �� 53      $��* �6#   �� 54      $	��560 �6#   �� 55      $	��560 �6#   �� 56      $��* �6#    � RowDefinitions 59      �� 5:      $	��140 �6    �� 5;      $	��530 �6    �� 5<      $��70 �6    .+�5B      �� $��0��6   $��1��5C      $��2��5D      $!��T R I M I T E   O F E R T E��5E      ���#CDD7E0$��Oswald)�5G      $��36(�5H      $��	20,50,0,0q�5I      $
��Bold"�6+    J� Effect 5J      3  -System.Windows.Media.Effects.DropShadowEffect  5K      5M      �� 5O      -   5         ��Name$ 	UsersList��5O      $��1��5P      $��1��5Q      $��0,0,0,20q�5R      
������ ���#CDD7E0$��Oswald)�5U      $��25(�5V      5X      �� 5Z      -   5         ��Name$ SelectAllUsers��5Z      $��1��5[      $��2��5\      $��42��5]      $	��114��5^      $	��Top=�5_      $
��Left=�5`      $��	30,10,0,0q�5a      $��Selectează tot��5b      ���	#FF23241E
�������$��17(�5e      5g      �� 5i      -   5        $
 Send��5i      $��1��5j      $��2��5k      $��42��5l      $	��114��5m      $��Bottom=�5n      $
��Left=�5o      $��	30,0,0,10q�5p      $��Trimite oferte��5q      ���	#FF23241E
�������$��17(�5t      6#   � 5x      $��2��6   $��0��5y      $��6��5z      $��Center=�5{       5}      �� 5~      $��25 �6'   �� 5      $
��1170 �6'   �� 5�      $��25 �6'   .+�5�      �� $��1��6   
������ $��0,0,0,0q�5�      $��Right=�5�      ._�5�      �  5�      �� 5�      $	��293 �6/   �� 5�      $	��293 �6/   �� 5�      $	��293 �6/   �� 5�      $	��293 �6/   .+�5�      �� -   5        $
 home��5�      $��0��5�   !   $��0,0,0,0q�5�      ��5�      �� 5�   "    j� Stretch$ Uniform=�5�      $ ../Images/homeicon.png��6/   .��5�      � $��60��6$    � HorizontalOffset$	 -12��5�       � PlacementTarget 5�      ��  �� ElementName$
 home����5�      �� $
 home�� �� Path$ IsMouseOver� �� Mode$ OneWay=�.��5�   "   � .+�5�   &   �� ���#F0F0F0 �� Padding$ 5q�5�   %   ._�5�   *   �� $��Acasa��64   
���   �$
��Bold"�5�   -   $��14(�5�   -   5�   '   5�   #   5�      5�      �� 5�      -   5        $ 
addaccount��5�      $��1��5�   !   $��0,0,0,0q�5�      ��5�      �� 5�   "   $ Uniform=�5�      $ ..//Images/add-user.png��6+   .��5�      � $	��155��6$   $	 -20��5�       5�      �� $ 
addaccount����5�      �� $ 
addaccount��$ IsMouseOver�$ OneWay=�.��5�   "   � .+�5�   &   �� ���#F0F0F0$ 5q�5�   %   ._�5�   *   �� $��Adauga cont de angajat��64   
���   �$
��Bold"�5�   ,   $��14(�5�   ,   5�   '   5�   #   5�      5�      �� 5�      -   5        $ offers��5�      $��2��5�   !   $��0,0,0,0q�5�      ��5�      �� 5�   "   $ Uniform=�5�      $ ..//Images/voucher.png��6/   .��5�      � $	��120��6$   $ -6��5�       5�      �� $ offers����5�      �� $ offers��$ IsMouseOver�$ OneWay=�.��5�   "   � .+�5�   &   �� ���#F0F0F0$ 5q�5�   %   ._�5�   *   �� $��Trimite Oferte��64   
���   �$
��Bold"�5�   ,   $��14(�5�   ,   5�   '   5�   #   5�      5�      �� 5�      -   5        $
 stoc��5�      $��3��5�   !   $��0,0,0,0q�5�      ��5�      �� 5�   "   $ Uniform=�5�      $  ..//Images/ready-stock.png��6/   .��5�      � $	��155��6$   $	 -20��5�       5�      �� $
 stoc����5      �� $
 stoc��$ IsMouseOver�$ OneWay=�.��5  "   � .+�5  &   �� ���#F0F0F0$ 5q�5  %   ._�5  *   �� $��Verificare stoc��64   
���   �$
��Bold"�5  -   $��14(�5  -   5	  '   5
  #   5     5     5     5     5     5     � 5  
   $��50��6   $��50��5     $��Right=�5     $	��Top=�5     $��	0,30,73,0q�5     .+�5      �� -   5        $
 user��5      $��0,0,0,0q�6#   ��5"     �� 5$     $ Uniform=�5%     $  ../Images/profile-user.png��6    5)     5+     � 5.  
   $��50��6   $��50��5/     $��Right=�50     $	��Top=�51     $��	0,30,10,0q�52     .+�53     �� -	   5        $ ExitBtn��53     $��0,0,0,0q�54     ��57     �� 59     $ ../Images/close.png��6!   $ Uniform=�5:     5>     5?     5A     5C     