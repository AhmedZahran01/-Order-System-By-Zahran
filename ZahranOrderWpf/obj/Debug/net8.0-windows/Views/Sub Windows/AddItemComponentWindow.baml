   M S B A M L   `   `   `  ����I  EZahranOrderWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:ZahranOrderWpf.Views.Sub_Windows ZahranOrderWpf.Views.Sub_Windows  5   	   =    7ZahranOrderWpf.Views.Sub_Windows.AddItemComponentWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:ZahranOrderWpf.Views.Sub_Windows     5   	   -   5          � Title$  AddItemComponentWindow��5
   	   $	��360��6(   $	��600��5   	    � WindowStyle$
 None=�6    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      � $��0��6   .+�5      ]� .+�5      �� $
��Item��6    $
��Left=�6,   $��18(�5       $
��Bold"�6.   $��15q�6@   5      �� 5       -   5        $��×��5       $��16(�5!      $
��Bold"�6+   $��Right=�5"      $��10q�69   5#      5%      5&      � 5,      $��1��6   $��Center=�6    .+�5-      �  5.      �� 5/      �� 50      �� 51      �� 52      �� 53      �� 54      �� 55      .+�57      �� $��0��6!    �� Orientation$ Vertical=�6.   $��	15,0,0,10q�6E   .+�58      �� $��Item *��6"   �� 59      $��12(�6$   $	��200��62   $
��Left=�6>   �� 5:      $��Search by SKU��6    $��12(�68   
���iii�6F   5;      �� 5<      $��4��6!   $��	15,0,0,10q�6.   $ Vertical=�6A   .+�5=      �� $��Measurement Unit *��6"   �� 5>      -   5         ��Name$ MeasurementComboBox��5>   %   $	��200��6C   $
��Left=�6O    �� DisplayMemberPath$
 Name��6j   5?      �� 5@      $��5��6!   $��	15,0,0,10q�6.   $ Vertical=�6A   .+�5A      �� $��
Quantity *��6!   �� 5B      $��12(�6$   $	��200��62   $
��Left=�6>   5C      5D      5E      ]� 5K      $��2��6   $��
15,15,15,0q�6%   .+�5L      �� $
��left=�5M      $
��Save��6*   $��90��5N      $��5q�6   �� 5O      -   5        $��Right=�5P      $��Close��6+   5Q      5R      5T      5V      5X      