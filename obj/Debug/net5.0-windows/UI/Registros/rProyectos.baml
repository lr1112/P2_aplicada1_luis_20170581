   M S B A M L   `   `   `  ����J  Fsegundo_parcial, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:segundo_parcial.UI.Registrossegundo_parcial.UI.Registros  5   	   -    'segundo_parcial.UI.Registros.rProyectos   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:segundo_parcial.UI.Registros     5   	     � Title$  Registro de Proyectos��5   	   $	��550��6'   $	��550��64   .��5	      �  � RowDefinitions 5
   
   �� 5      $��55 �6   �� 5      $��55 �6   �� 5      $��80 �6   �� 5      �� 5      $��35 �6   �� 5      $��45 �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� .+�5      �� $��
ProyectoId��6   $��70��6-   $��Center=�68   $
��Left=�6S   �� 5      -   5         ��Name$ ProyectoIdTextBox��5      $	��150��6Q   $��20��6]   $��Center=�6i   ��65   �� *
ProyectoId+6i   5      �� 5      -   5         ��Name$ BuscarBoton��5      $��85��6*   $��30��65   $��10,0,0,0q�6A   
���   ����	#FF02A5ED.��5      �� $ 
Horizontal=�6   .+�5      �� $��\Imagenes\search.png��6   6<   �� 5       $��Buscar��6    
���   �$
��Bold"�6D   5!      5"      5#      �� 5&   
   $��1��6   .+�5'      �� $��Fecha��6   (  "System.Windows.Controls.DatePicker  5(      -   5          Name$ FechaDatePicker��5(      $��1��62   $	��150��6?   $
��Left=�6j      SelectedDate 6K   �� *Fecha+6j   5)      �� 5,   
   $��2��6   .+�5-      �� $��Descripción del proyecto��6   �� 5.      -   5        $ DescripcionTextBox��5.      $	��5,0q�6O   $��50��6\   ��62   �� *Descripcion+6\   5/      �� 51   
   $��Detalle��6   $��3��6$   .��52      �  53      �� 54      $��55 �6$   �� 55      �� 56      $��30 �6$   .+�59      � $��0��6    � ColumnDefinitions 5:      �� 5;      �� 5<      �� 5=      �� 5>      $
��Auto �6+   .+�5B      �� $��0��6!   .+�5C      �� $��Tipo tarea:��6    �� 5D      -   5         ��Name$ TareasComboBox��5D   #   5E      �� 5H      $��1��6!   $��5,0,0,0q�61   .+�5I      �� $��Requerimiento��6    �� 5J      -   5        $ RequerimientoTextBox��5J   "   $��22��6@   5K      �� 5N      $��2��6!   $��5,0,0,0q�61   .+�5O      �� $��Tiempo (minutos)��6    �� 5P      -   5        $ TiempoTextBox��5P   "   $	��100��69   $��22��6E   $
��Left=�6Q   5Q      �� 5T      -   5        $ AgregarBoton��5T      $��3��63   $��85��6C   $��28��6N   $��Right=�6Z   ���	#FF18EB39
���   �.��5U      �� $ 
Horizontal=�6%   .+�5V      �� $��18��6$   $��18��6/   $��/Imagenes/add.png��6;   �� 5W      $��Agregar��6$   
���   �$
��Bold"�6I   5X      5Y      5Z      &   System.Windows.Controls.DataGrid  5]      -	   5        	  Name$	 TareasDataGrid��5]      $��1��63   
   AutoGenerateColumns$
 False��6@      
IsReadOnly$
 True��6\      RowHeaderWidth$ 0Q�6n      Columns 5^      0  *System.Windows.Controls.DataGridTextColumn  5_      ,  &System.Windows.Controls.DataGridColumn   Header$ TipoId��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$
 .25* 6=   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6J   �� *TipoId+  5`      $ 
Tipo Tarea��6-   $	 .3* 6A    6M   �� *Tipo+  5a      $ Requerimiento��6-   $ * 6D    6N   �� *Requerimiento+  5b      $ Tiempo��6-   $	 .3* 6=    6I   �� *Tiempo+5d      �� 5g      -
   5        $ RemoverBoton��5g      $��2��6/   $��85��6<   $��28��6G   $��Right=�6S   ���	#FFF02121
���   �.��5h      �� $ 
Horizontal=�6!   .+�5i      �� $��18��6    $��18��6+   $��/Imagenes/cancel.png��67   �� 5j      $��Remover��6    
���   �$
��Bold"�6E   5k      5l      5m      5n      �� 5p   
   $��4��6   $ 
Horizontal=�6"   $��Right=�6;   .+�5q      �� $��Tiempo total��6   $��Center=�6+   �� 5r      -   5        $ TiempoTotalTextBox��5r       �� 
IsReadOnly$
 True��62   $	��150��6D   $��22��6P   $
��Left=�6y   ��6\   �� *TiempoTotal+6y   5s      �� 5v   
   $��5��6   $ 
Horizontal=�6"   $��Center=�6;   $��Center=�6X   $��30��6s   .+�5w      �� -   5        $ 
NuevoBoton��5w      $��90��6)   $��5,0,0,0q�64   ���	#FFFCEF32
���   �.��5x      �� $ 
Horizontal=�6   .+�5y      �� $��18��6   $��18��6'   $��/Imagenes/new.png��63   �� 5z      $��Nuevo��6   
���   �$
��Bold"�6?   5{      5|      �� 5}      -   5        $ GuardarBoton��5}      $��90��6+   $��20,0,0,0q�66   ���	#FF18EB39
���   �.��5~      �� $ 
Horizontal=�6   .+�5      �� $��18��6   $��18��6'   $��/Imagenes/save.png��63   �� 5�      $��Guardar��6   $
��Bold"�6.   5�      5�      �� 5�      -   5        $ EliminarBoton��5�      $��90��6,   $��20,0,0,0q�67   ���	#FFF02121
���   �.��5�      �� $ 
Horizontal=�6   .+�5�      �� $��18��6   $��18��6'   $��/Imagenes/delete.png��63   �� 5�      $��Eliminar��6   $
��Bold"�6/   5�      5�      5�      5�      5�      