   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   )clr-namespace:WpfApp1.UCFWpfApp1.UCF  6-       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   )UCFclr-namespace:WpfApp1.UCF     6-   -   5        ���#141414  � WindowStartupLocation$  CenterScreen=�5       � Title$ CryptoSuivi��5	   	   $	��600��6   $
��1000��6*   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��9* �6   �� 5      $��* �6   �� 5      $	��25* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��4* �6   �� 5      $	��10* �6   �� 5      $��4* �6   �� 5      $	��15* �6   �� 5      $��2* �6   .+�5   
   �� -   5         ��Name$ titreCrypto��5   $   $��1��6   $
��Left=�69   $��Mes Cryptos��6T   
�������$��29(�6z   $
��Bold"�6�   $��Bottom=�6�   �� 5   
   -   5        $ 	titreNews��5   $   $��3��6   $
��Left=�67   $��Les News��6R   
�������$��29(�6u   $
��Bold"�6�   $��Bottom=�6�   �� 5   
   -   5        $ 
titreGraph��5   1   $��3��6   $��2��6$   $
��Left=�6E   $��Le Graph��6`   
�������$��29(�6�   $
��Bold"�6�   $��Bottom=�6�   �� 5"   
   $��1��6   $��1��6%   $��3��65   $��Hidden=�6F   $
��Auto=�6m   .��5#      (� .��5$      �� -   5         ��Name$ afficheurCryptos��5)      
������ 
������  
  Style2#��[  5&       �� SelectedIndex$ 0��5(      $��Center=�5+      $	��Top=�5,      ��5*      �� *
LesCryptos+��5-      �� 5.      .R�5/      �  � Orientation$ Vertical=�6(   50      ��52      �� 53      .R�54      � $��50��6#   $	��200��6/   .+�55   "      WpfApp1.UCF.UC_CryptoMini  56      57      59      5;      5<      �� 5?   
   -   5        $��Button��5?      $��1��6"   $��Right=�6F   $��Bottom=�6b   � 5A   
   $��1��6   $��3��6   .+�5B         WpfApp1.UCF.UC_CryptoNews  -   5          Name$ lesNews��5B       $��Stretch=�61   	 � DataContext	 6O   �� 
 �� ElementName$
 afficheurCryptos�� �� UpdateSourceTrigger$ PropertyChanged=� �� Path$ SelectedItem�5C      5E      5F      