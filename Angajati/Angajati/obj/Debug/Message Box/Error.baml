   M S B A M L   `   `   `  ����  Angajati     Angajati.Message_Box.Error   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Error��5   	   $	��200��5   	   $	��400��6    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � Topmost .  � ShowInTaskbar .     MaterialDesignBody#���   5   	   $��Regular"�5   	   $��12(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	   .��5      � $��10q�6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       $��2 �6   �� 5"      $
��Auto �6   �� 5$      $
��Auto �6   �� 5&      $
��Auto �6   .+�5+   
   �� $��/Images/eroare.png��6   $��50��5,      $��36��5-      $	��Top=�5.      $
��Left=�5/      $��2��6+   $��2,2,0,0q�6?   $��0��6P   �� 52   
   $��1��6   $��18(�53      $
��Bold"�54      $��Eroare��55      
���  ��$	��Top=�57      $
��Left=�58      $��	61,10,0,0q�59      �� 5;   
   $��2��6   $��1��6   
��� ���$��0,1,0,0q�5=      $��
-15,5,0,10q�5>      �� 5A   
   -   5        	 ��Name$	 lblErrorMessage��5A      $��3��5B      $��1��6   $��0,10,0,0q�5C      
 �� TextAlignment$

 Left=�5D      $	��Top=�5E      
���   �$��16(�5G      $
��Wrap=�5H      $��50��5I      $��2��5J      �� 5N   
   $��7��6   $��1��6"    �� Orientation$ 
Horizontal=�5O      $��Right=�5P      .+�5Q      �� -   5        $��OK��5Q      $��80��5R      $��30��5S      ���#D70040
�������5U   (   �� 5V      -   5        $��Cancel��5V      $��80��5W      $��30��5X      ���#E0E0E0
���   �5Z   (   5[      5\      5]      