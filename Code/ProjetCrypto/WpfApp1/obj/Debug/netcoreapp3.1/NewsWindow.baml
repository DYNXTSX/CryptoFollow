   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5      )clr-namespace:WpfApp1.UCFWpfApp1.UCF  6+       WpfApp1.NewsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5      )UCFclr-namespace:WpfApp1.UCF     6+     � Title$  	Some news��5	      $	��500��5
      $	��600��6   ���#141414.��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $	��15* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $	��10* �6   �� 5      $
��1.5* �6   .+�5   
   �� $��1��6   $��1��6%   $��3��65   $��Hidden=�6F   $
��Auto=�6m   .��5      (� .��5      �� -   5         ��Name$ afficheurCryptos��5      
������ 
������  �� SelectedIndex$ 0��5      $��Center=�5      $��Center=�5       ��5      �� *
LesCryptos+��5!      �� 5"      .R�5#      �  � Orientation$ Vertical=�6(   5$      ��5&      �� 5'      .R�5(      � $��50��6#   $	��400��6/   .+�5)   "      WpfApp1.UCF.UC_ChangeNews  5*      5+      5-      5/      50      �� 53   
   -   5         ��Name$ titreCrypto��53   $   $��1��6   $��Center=�69   $��Les évolutions��6V   
�������$��29(�6   $
��Bold"�6�   $��Center=�6�   �� 54   
   -   5         ��Name$ bouttonvalid��54         bouttonvaliderajout#��[  6'   $��Center=�6T   $��1��6q   6�   56      57      