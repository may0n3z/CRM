   M S B A M L   `   `   `  ����@  <var11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:var11var11  5   	       var11.ManagementDB   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:var11     5   	   -   5          � Title$  ManagementDB��5   	   $	��450��6G   $	��800��6T   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��377* �6   �� 5      $	��50* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
DGridOrder��5         AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО заказчика��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6[   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *
NamePeople+6g     5      $ 
Почта��6%   $ * 6M    64   �� *Mail+6Y   5      �� 5   
   -   5        	 ��Name$
	 Back��5      $��
Назад��6   $
��Left=�6/   $��33��6J   $��Center=�6V   $	��220��6q   $��	570,0,0,0q�6}   $��1��6�   �� 5   
   -   5        $	 Update��5      $��Обновить��6!   $
��Left=�64   $��33��6O   $��Center=�6[   $	��220��6v   $��10,0,0,0q�6�   $��1��6�   5      5      