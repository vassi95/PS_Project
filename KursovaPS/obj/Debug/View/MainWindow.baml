   M S B A M L   `   `   `  ����D  @KursovaPS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:KursovaPS.ViewModelKursovaPS.ViewModel  5   	       KursovaPS.View.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:KursovaPS.ViewModel     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � DataContext 5	      %  KursovaPS.ViewModel.MyViewModel  5
   
   .��5      � ��5   
   �� 5       �� ImageSource$W Qc:\users\i333468\documents\visual studio 2017\Projects\KursovaPS\KursovaPS\11.jpg��6    j� Stretch$ UniformToFill=�6y   .+�5   
   r� -   5        $��mediaElement1��5   ]   $	��100��6   $	��100��6$   $��10,10,407,0q�60    r� LoadedBehavior$ Manual=�6E   $	��Top=�6r    r� Source$Z Tc:\users\i333468\documents\visual studio 2017\Projects\KursovaPS\KursovaPS\music.mp3?�6�   �� 5   
   $
��PLAY��6   $
��Left=�6    $��374,262,0,0q�6;   $	��Top=�6P   $	��123��6h   $��38��6t   ���	#FF3DC143���	#FF486847 �� IsCancel . $��20(�6�   $
��Bold"�6�   ��6�   �� *PlayCommand+�� 5   
   $��RULES��6   $
��Left=�6!   $��
21,262,0,0q�6<   $	��Top=�6P   $	��123��6h   $��38��6t   ���	#FFC8FDE3���	#FF375736 . $
��Bold"�6�   $��20(�6�   ��6�   �� *RulesCommand+5      5      