   M S B A M L   `   `   `  ����e  aUTR_E9.WPF.Listas__máscaras_y_conversores, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:UTR_E9.WPF.Listas__máscaras_y_conversores*UTR_E9.WPF.Listas__máscaras_y_conversores  5   	   g8clr-namespace:UTR_E9.WPF.Listas__máscaras_y_conversores*UTR_E9.WPF.Listas__máscaras_y_conversores  5   	   ;    5UTR_E9.WPF.Listas__máscaras_y_conversores.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Jlocal8clr-namespace:UTR_E9.WPF.Listas__máscaras_y_conversores     5   	   O
converters8clr-namespace:UTR_E9.WPF.Listas__máscaras_y_conversores     5   	     � Title$  Gestión de Reservas��5	   	   $	��450��6%   $	��800��62    � 	Resources 5
      @   :UTR_E9.WPF.Listas__máscaras_y_conversores.AsisteConverter   AsisteConverter��%   &	          5   
   6%   5      .��5      � .+�5   
   �� -   5         ��Name$ 	txtFiltro��5      $	��500��6%   $��25��61   $��0,0,250,350q�6=   �� 5   
   -   5         ��Name$ 	btnFiltro��5      $��80��6$   $��25��6/   $��Filtrar��6;   $��350,0,0,350q�6M   6b   �� 5   
   -   5        $ btnNueva��5      $��80��6:   $��25��6E   $��Nueva��6Q   $��660,0,0,350q�6a   �� 5   
   -   5        $��
lvReservas��5   &   $��	0,30,20,0q�6   $	��725��68   $	��330��6D   $��Visible=�5       �� View 5      �� 5      .P�5      �� $��Fecha��6%    �� Width$	 120��64    �� DisplayMemberBinding 6@   �� *Fecha+ �� StringFormat$ 
dd/MM/yyyy���� 5      $��Nombre��6%   $	 240��65    6A   �� *Nombre+�� 5      $��
Comensales��6%   $	 150��69    6E   �� *
Comensales+�� 5      $��Asiste��6%   $	 150��65    �� CellTemplate 5      �� 5      .R�5   "   �� ��6,   �� *Asiste+	 �� 	Converter#	 [  5      5      5!      
 � ContextMenu
 5#      �� 5$      .@�5%      m� -   5        $��Nueva��5%      6.   m� 5&      -   5        $	��Ver��5&      6,   m� 5'      -   5        $��Borrar��5'      6/   �� 5(      m� 5)      $��	Confirmar��6    m� IsCheckable . 62   5*      5-      �� 5/   
   -   5         ��Name$ lblFiltrado��5/   %   $��
Sin Filtro��6   $��0,380,620,0q�6:   $	��130��6O   $��25��6[   �� 50   
   -	   5        $ lblRegistros��50   &   $��0 Registros��6   $��700,380,0,0q�6<   $��80��6Q   $��25��6\   52      53      