   M S B A M L   `   `   `  ����C  ?Angajati, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AngajatiAngajati  5   	       Angajati.LoginPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Angajati     5   	     � Title$  Window1��5   	   $	��770��6   $
��1220��6&    � WindowStartupLocation$ CenterScreen=�63   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��1.5* �6   .+�5   
   ��  �� CornerRadius$ 	10 0 0 10��6   ��5      �� 5       �� ImageSource$ /Images/triangles.png��6    j� Stretch$ UniformToFill=�6A   5      � 5   
   .+�5      �� $��Center=�6   .+�5      �� $��Sign Up��6      	titleText#��[  6+   �� 5      $.��(Contactați-ne pentru mai multe detalii!��6     
normalText#��[ 6K    J� Opacity$	 0.8Q�6o   $��20 30q�6}   �� 5      -   5        $��Sign Up��5       
 button#��[ 6+   
�������6^   5      5      �� 5   
   -   5        ���#ffffff$��1��5   &   $ 	0 10 10 0��66   ._�5      �� $��Center=�6   .+�5       �� $��Log In!��6   #��[  6+   ���#2658286N   �� 5"      $6��0Introduceți datele dumneavoastră de conectare!��6   #��[ 6R   ���#878787$��	0 10 0 15q�6�   �� 5#      $��1q�6   ���#acb0af$
��70 7q�6C   $ 10��6Q   ._�5$      � $	��7 9q�6    5%      �� 5&      $
��auto �6/   �� 5'      $��* �6/   .+�5)      �� $��/Images/Email.jpg��6    $��20��6;   $��2��6G   $��	0,0,547,1q�6[   �� 5*      -   5         ��Name$ 	textEmail��5*   $   $�� ��6W     textHint#��[ 6_   �� 5+      -   5         ��Name$ txtEmail��5+   "     textBox#��[ 6W   $��1��6x   $��55,0,0,0q�6�   5-      5/      �� 50      $��1q�6   ���#acb0af$
��70 7q�6C   $ 10��6Q   ._�51      � $��0,9,0,9q�6   $	��574��6,    52      �� 53      $
��auto �6/   �� 54      $��* �6/   .+�56      �� $��/Images/Password.jpg��6    $��20��6>   �� 57      -   5        $ textPassword��57   "   #��[ 68   $��1��6Y   $��69,0,0,0q�6i   $
��Left=�6{   $	��358��6�   G� 58      -   5        	 G�Name$	 txtPassword��58   &     passwordBox#��[ 6;   $��1��6`   $��
10,0,112,0q�6p   �� 59      -   5        $ txtPasswordVisible��59   "   #��[ 6>   $��1��6_   $��
10,0,112,0q�6o   $y�	Collapsed=�6�   �� 5:      -   5        
 ��Name$
 showPasswordCheckBox��5:   :   $��Arată parola��6#   $��1��5<      $��Center=�6'   $��Right=�6B   $��0, 0, 10, 0q�6^   5=      5>      �� 5?      -	   5        $��Forgot password?��5?      $��Center=�5@      $��Center=�5A      $��10q�5B      
�������$��2q�5D      
������ ���#265828$��16(�5G       � Cursor$
 Hand��5H      ��5I      �� 5J       �� 
TargetType" ��6    .�5K      ��  �� Property � �� �� Value 5L   "   �� 5M   &    �� 
TargetType" ��66   .R�5N   *   �� #��z��61   #��z��5O   !   #��z��5P   !   $ 5��5Q   !   ._�5R   .   �� $��Center=�6?   $��Center=�6\   5S   +   5T   '   5V      �� 5W       � ��
 �2�2�6;   �� 5X       � ��$ 16(�69   5Y      5[      �� 5]      -
   5        $��Log In��5]        
mainbutton#��[ 6?   �� 5_      $1��+Contactați-ne pe rețelele de socializare!��6   #��[ 6M   ���#265828$��0 10 0 0q�6�   �� 5`       �� Orientation$ 
Horizontal=�6   $
��0 10q�66   $��Center=�6D   .+�5a      �� -   5          buttonCircle#��[ 5a      .��5b      �� $��/Images/Facebook.png��6    $��30��6>   $��30��6I   5c      �� 5d      -   5        #��[ 5d      .��5e      �� $��/Images/Instagram.png��6    $��25��6?   $��25��6J   5f      �� 5g      #��[ 6   .��5h      �� $��/Images/Gmail.jpg��6    $��25��6;   $��25��6F   5i      5k      5m      5o      5u      5v      