   M S B A M L   `   `   `  ����R  NUnidad2Actividad4Vuelos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Unidad2Actividad4VuelosUnidad2Actividad4Vuelos  5   	   (    "Unidad2Actividad4Vuelos.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Unidad2Actividad4Vuelos     5   	   -   5          � Title$  
MainWindow��5   	   $	��560��6   $	��800��6)   .��5	      ]� ��5
   
   �� 5       �� ImageSource$ 
fondo2.jpg��6    j� Stretch$
 Fill=�62   6C   .+�5   
   � $	��Top=�6   $��80��6%   $��10q�61   .+�5      �� $��	globo.png��6   $��5q�6'   $
��Left=�62   6O   �� 5      $��30(�6    �� TextAlignment$ Center=�6&    �� Padding$ 10q�5      
�������$��DemiBold"�5      $��Center=�6*   Administrador de vuelos5      5      � 5   
   $��Right=�6   $��Bottom=�60   $��0q�6H   $��70��6S    � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       �� 5      " ��6   .�5      ��  � ��$ 20(�61   6>   �� 5       � ��$
 20,0q�6/   6>   �� 5       � ��
 ���� 6I   �� 5       � ��$ 0q�68   6D   5      5       .+�5"      �� -   5        	 ��Name$	 
btnAgregar��5"      .��5#      �� $��boton-anadir.png��6   64   5$      �� 5%      -   5        $	 	btnEditar��5%      .��5'      �� $��Editar1.png��6   6/   5(      �� 5)      -   5        $��btnEliminar��5)      .��5+      �� $��Cerrar(1).png��6   61   5,      5-      �� 50   
   $��20q�6   ���	#FF11067E$��10q�65   
 �� CornerRadius$
 5��51      ._�52      &   System.Windows.Controls.DataGrid  -   5          Name$ dtgListaVuelos��52         CanUserAddRows .  $��16(�53      $	��300��6%      CanUserResizeColumns .     AlternatingRowBackground
 ��·�   SelectionMode$ Extended=�55   C   ��6   �� *ClienteVuelos.Model+57      58      �� 59   
   $��10,20q�6   $��Right=�6$   ��5:      �� 5;       �� Color$ 	#FF11067E��6"    �� Opacity$ .5Q�64   6C    5=      ��%S  '��       '�� �     �� 5>      " ��6   .�5?      ��  � ��$ 18(�61   6>   �� 5@       � ��$ 5q�6/   6;   �� 5A       � ��$ DemiBold"�63   6F   �� 5B       � ��
 �����6C   5C      �� 5D      " ��6   .�5E      ��  � ��$ 16(�61   6>   �� 5F       � ��$ 5q�6/   6;   5G      5H      .+�5I      �� 
�������$��18(�6'   $��DemiBold"�5J      $��Center=�6*   .��6G   Agregar Vuelo5L      �� 5M      Hora:6   �� 5N      -   5        $��txtHora��5N   7   $��5q�6   ��6!   �� *Hora+6H   �� 5O      
Destino:6"   �� 5P      -   5        $��
txtDestino��5P   :   $��5q�6   ��6!   �� *	Destino+6N   �� 5Q      Vuelo:6    �� 5R      -   5        $��txtVuelo��5R   8   $��5q�6   ��6!   �� *Vuelo+6J   �� 5S      	Estado:6!   �� 5T      -	   5        $��	cmbEstado��5U      $��5q�5T      $��16(�5U   (    �� SelectedValue 5T   "   �� *Estado+5W      5X      5Z      5[      