   M S B A M L   `   `   `  ����C  ?KOSMETIK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:KOSMETIK.StrWindowKOSMETIK.StrWindow  5      %    KOSMETIK.StrWindow.AdminProduct   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:KOSMETIK.StrWindow     5        N� Title$  Продукция��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��30 �6   .+�5   
   �  � Orientation$ 
Horizontal=�6    � 
ItemHeight$ 30��6-   .+�5      �� $��Поиск: ��6   $��10,0,0,0q�6&   $��Center=�68   �� 5      -   5         ��Name$ SearchFilterTextBox��5   =   $	��200��6   $��Center=�6"   6Z   �� 5      $��Сортировка: ��6   $��10,0,0,0q�6+   $��Center=�6=   �� 5      -   5        $��SortTypeComboBox��5       �� SelectedIndex$ 0��6/   $��Center=�6A   $	��200��6\   ��5   L   �� *
SortList+�� 5      $��Фильтрация: ��6   $��Center=�6+   �� 5      -   5         ��Name$ ProductTypeFilter��5   #   $	��150��6   $��Center=�6>    �� DisplayMemberPath$ ManufacturerName��5       $ 0��66   ��6H   �� *
FilterList+5!      �� 5#   
   -   5         ��Name$ Btn_Cls��5#      $��1��62   $)��#Добавить продукцию��6?   $
��Left=�5$      $��Center=�6,   �� 5&   
   -   5        	 ��Name$	 ProductListView��5&   0   $��2��6   $��1��6    ��5'      �� *ProductList+��5)      �� 5*      .R�5+      �� $��1q�6   
���   ���61   �� *BackgroundColor+._�5,      � $��10q�6   $��Stretch=�6+   
 � ColumnDefinitions
 5-      �� 5.   "   $��64 �63   �� 5/   "   $��* �63   �� 50   "   $
��auto �63   �� 51   "   $
��auto �63   .+�54      �� $��64��6I   $��64��6T   ��6$   ��  �� Path$ ProductPhoto�6T   �� 56      $��1��6)   $��5q�69    �� Orientation$ Vertical=�6D   .+�58   "   �� $ 
Horizontal=�6-   .+�59   &   �� $
��Bold"�6M   ��60   �� *ProductName+6M   5:   #   �� 5<   "   $ 
Horizontal=�6-   .+�5=   &   �� ��60   �� *ProductDescription+5>   #   �� 5@   "   $ 
Horizontal=�6-   .+�5A   &   �� $"��Производитель: ��60   �� 5B   &   ��60   �� *Manufacturer.ManufacturerName+5C   #   �� 5E   "   $ 
Horizontal=�6-   .+�5F   &   �� $��
Цена: ��60   �� 5G   &   ��60   �� *ProductCost+5H   #   5I      �� 5K      $��На складе:��6(   $��2��6:   $	��Top=�6J   $��Right=�5L   (   $��10q�6D   �� 5N      $��2��6P   $��Center=�6`   $��Right=�5O   (   $��10q�6D   ��5N   (   �� *ProductQuantityInStock+5O   D   �� 5Q      $��2��6E   $��Bottom=�6U   $��Right=�5R   -   $��10q�6I   ��5Q   (   �� *ProductUnit+5R   I   �� 5T      $��3��6)   .+�5U   "   �� $��BtnEdit��6A   -   5        $ ��Редактировать��5U   )   6P   �� 5V   "   $ Btn_Clv��6)   -   5        $��Удалить��5V   M   5W      5X      5Y      5Z      5\      5]      5^      