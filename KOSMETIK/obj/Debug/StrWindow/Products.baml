   M S B A M L   `   `   `  ����C  ?KOSMETIK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:KOSMETIK.StrWindowKOSMETIK.StrWindow  5      !    KOSMETIK.StrWindow.Products   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:KOSMETIK.StrWindow     5        N� Title$  Продукты��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��30 �6   .+�5   
   �  � Orientation$ 
Horizontal=�6    � 
ItemHeight$ 30��6-   .+�5      �� $��Поиск: ��6   $��10,0,0,0q�6&   $��Center=�68   �� 5      -   5         ��Name$ SearchFilterTextBox��5   =   $	��200��6   $��Center=�6"   5      �� 5      $��Сортировка: ��6   $��10,0,0,0q�6+   $��Center=�6=   �� 5      -   5        $��SortTypeComboBox��5       �� SelectedIndex$ 0��6/   $��Center=�6A   $	��200��6\   ��5   L   �� *
SortList+�� 5      $��Фильтрация: ��6   $��Center=�6+   �� 5      -   5         ��Name$ ProductTypeFilter��5   #   $	��150��6   $��Center=�6>    �� DisplayMemberPath$ ManufacturerName��5       $ 0��6_   ��6<   �� *
FilterList+6_   5!      �� 5#   
   -   5         ��Name$ ProductListView��5#   0   $��2��6   $��1��6    ��6I   �� *ProductList+��5$      �� 5%      .R�5&      �� $��1q�6   
���   ���61   �� *BackgroundColor+._�5'      � $��10q�6   $��Stretch=�6+   	 � ColumnDefinitions	 5(      �� 5)   "   $��64 �63   �� 5*   "   $��* �63   �� 5+   "   $
��auto �63   �� 5,   "   $
��auto �63   .+�5/      �� $	��Img��6$   $��64��6T   $��64��6_   ��6/   �� 
 �� Path$
 ProductPhoto�6_   �� 51      $��1��6)   $��5q�69    �� Orientation$ Vertical=�6D   .+�52   "   �� $ 
Horizontal=�6-   .+�53   &   �� $
��Bold"�6M   ��60   �� *ProductName+6M   54   #   �� 56   "   $ 
Horizontal=�6-   .+�57   &   �� ��60   �� *ProductDescription+58   #   �� 5:   "   $ 
Horizontal=�6-   .+�5;   &   �� $"��Производитель: ��60   �� 5<   &   ��60   �� *Manufacturer.ManufacturerName+5=   #   �� 5?   "   $ 
Horizontal=�6-   .+�5@   &   �� $��
Цена: ��60   �� 5A   &   ��60   �� *ProductCost+5B   #   5C      �� 5D      $��На складе:��6(   $��2��6:   $	��Top=�6J   $��Right=�6b   $��10q�6   �� 5F      $��2��6P   $��Center=�6`   $��Right=�5G   (   $��10q�6E   ��5F   (   �� *ProductQuantityInStock+5G   E   �� 5I      $��2��6E   $��Bottom=�6U   $��Right=�5J   (   $��10q�6D   ��5I   (   �� *ProductUnit+5J   D   5K      5L      5M      5O      5P      5Q      