   M S B A M L   `   `   `  ����J  FprojectRestoran, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:projectRestoranprojectRestoran  5   	       projectRestoran.Window10   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:projectRestoran     5   	     � Title$  Window10��5   	   $	��800��6   $	��600��6'   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��500 �6   �� 5      .+�5   
   �� -   5        $��StackOne��5      $
��Auto��6"   .@�5      �� $��Center=�6   .��5      �� -   5        $
��img1��5      $	��400��6$   5      �� 5      $��15(�6   $��Black"�6(   .��6;   %#Название ресторана6O   �� 5      $��Center=�6   $��15(�67   ��6E   ��  �� Path$ RestaurantName��� 5      $��15(�6   $��Black"�6(   .��6;   '%Категория ресторана6P   �� 5      $��Center=�6   $��15(�67   ��6E   �� $ RestaurantCategory��� 5      $��15(�6   $��Black"�6(   .��6;   Алкаголь дня6I   �� 5      $��Center=�6   $��15(�67   ��6E   �� $ 	dishesDay��� 5      $��15(�6   $��Black"�6(   .��6;   #!Рейтинг ресторана6N   �� 5      $��Center=�6   $��15(�67   ��6E   �� $ rating��� 5      $��15(�6   $��Black"�6(   .��6;   ,*Время работы ресторана6S   �� 5      $��Center=�6   $��15(�67   ��6E   �� $ workingHours��� 5      5      5       �� 5"   
   $��1��6   .+�5#      �� -   5        $
��res1��5#   '   
��� ���.��6F   
Меню6L   �� 5$      -   5        $
��back��5$   '   
����� �.��6F   
Назад6M   5%      5&      5'      