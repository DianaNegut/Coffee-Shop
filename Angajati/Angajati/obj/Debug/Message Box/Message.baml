   M S B A M L   `   `   `  ����  Angajati"    Angajati.Message_Box.Message   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Message��5   	   $	��180��5   	   $	��400��6    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � Topmost .  � ShowInTaskbar .     MaterialDesignBody#���   5   	   $��Regular"�5   	   $��12(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	   .��5      � $��10q�6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��2 �6   �� 5      $
��Auto �6   �� 5       $
��Auto �6   �� 5!      $
��Auto �6   .+�5%   
   �� $��/Images/succes.png��6   $��50��5&      $��36��5'      $	��Top=�5(      $
��Left=�5)      $��2��6+   $��2,2,0,0q�6?   $��0��6P   �� 5,   
   $��1��6   $��18(�5-      $
��Bold"�5.      $��Succes!��5/      
��� � �$	��Top=�51      $
��Left=�52      $��	61,10,0,0q�53      �� 55   
   $��2��6   $��1��6   
����  �$��0,1,0,0q�57      $��
-15,5,0,10q�58      �� 5;   
   -   5        	 ��Name$	 lblMessageContent��5;      $��3��5<      $��1��6!   $��0,5,0,0q�5=      
 �� TextAlignment$

 Left=�5>      $	��Top=�5?      
���   �$��14(�5A      $
��Wrap=�5B      $��29��6(   $��2��64   �� 5E   
   $��5��6   $��1��6"    �� Orientation$ 
Horizontal=�5F      $��Right=�5G      .+�5H      �� -   5        $��OK��5H      $��80��5I      $��30��5J      
��� � �
�������5L   (   �� 5M      -   5        $��Cancel��5M      $��80��5N      $��30��5O      ���#E0E0E0
���   �5Q   (   5R      5S      5T      