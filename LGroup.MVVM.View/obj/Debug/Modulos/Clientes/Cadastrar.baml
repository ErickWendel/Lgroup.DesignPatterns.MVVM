   M S B A M L   `   `   `  ����P  LLGroup.MVVM.ViewModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null~Sclr-namespace:LGroup.MVVM.ViewModel.Modulos.Clientes;assembly=LGroup.MVVM.ViewModel&LGroup.MVVM.ViewModel.Modulos.Clientes  5   	    LGroup.MVVM.View1   +LGroup.MVVM.View.Modulos.Clientes.Cadastrar   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   hClientesSclr-namespace:LGroup.MVVM.ViewModel.Modulos.Clientes;assembly=LGroup.MVVM.ViewModel     5   	     � Title$  	Cadastrar��5   	   $��350.923��6   $��430.627��6,    � DataContext 5      ?   9LGroup.MVVM.ViewModel.Modulos.Clientes.CadastrarViewModel  5   
   .��5	      � $��	0,0,5,0.5q�6    J� RenderTransformOrigin$ 0.379,0.395&�6    � RowDefinitions 5
   
   �� 5      $
��292* �6   �� 5      $��9* �6    � ColumnDefinitions 5   
   �� 5      $��4* �6   �� 5      $
��271* �6   �� 5      $	��25* �6   .+�5   
   �� $
��Nome��6   $
��Left=�6   $��	15,22,0,0q�6:   $	��Top=�6M   $��1��6e   �� 5   
   $��Email��6   $
��Left=�6    $��	15,63,0,0q�6;   $	��Top=�6N   $��1��6f   �� 5   
   $��Telefone��6   $
��Left=�6#   $��
15,112,0,0q�6>   $	��Top=�6R   $��1��6j   �� 5   
   $��Data de Nascimento��6   $
��Left=�6-   $��
15,163,0,0q�6H   $	��Top=�6\   $��1��6t   �� 5   
   $
��Left=�6   $��23��6-   $��162.5,25,0,0q�69    �� TextWrapping$
 Wrap=�6O   $	��Top=�6y   $	��174��6�   $��1��6�   ��6c   �� *Nome+6�   �� 5   
   $
��Left=�6   $��23��6-   $��162.5,75,0,0q�69   $
 Wrap=�6O   $	��Top=�6z   $	��174��6�   $��1��6�   ��6c   �� *Email+6�   �� 5   
   $
��Left=�6   $��23��6-   $��162.5,116,0,0q�69   $
 Wrap=�6P   $	��Top=�6~   $	��174��6�   $��1��6�   ��6d   �� *
Telefone+6�   (  "System.Windows.Controls.DatePicker  5   
   $
��Left=�6   $��162.5,165,0,0q�60   $	��Top=�6G   $	��174��6_   $��1��6k      SelectedDate 6{   �� *DataNascimento+�� 5   
   $��	Cadastrar��6   $��1��6%   $
��Left=�65   $��
32,224,0,0q�6P   $	��Top=�6d   $��75��6|   ��6�   �� *ClickCadastrar+�� 5   
   $��Limpar��6   $��1��6"   $
��Left=�62   $��261.5,224,0,0q�6M   $	��Top=�6d   $��75��6|   ��6�   �� *ClickLimpar+5      5      