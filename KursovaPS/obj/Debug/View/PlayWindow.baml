   M S B A M L   `   `   `  ����D  @KursovaPS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:KursovaPS.ViewModelKursovaPS.ViewModel  5   	       KursovaPS.View.PlayWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:KursovaPS.ViewModel     5   	     � Title$  
PlayWindow��5   	   $	��450��6   $	��625��6)    � DataContext 5	      %  KursovaPS.ViewModel.MyViewModel  5
   
   .��5      � ��5   
   �� 5       �� ImageSource$W Qc:\users\i333468\documents\visual studio 2017\Projects\KursovaPS\KursovaPS\33.jpg��6    j� Stretch$ UniformToFill=�6y   .+�5   
   r� -   5        $��mediaElement1��5   ^   $	��100��6   $	��100��6$   $��10,159,507,0q�60    r� LoadedBehavior$ Manual=�6F   $	��Top=�6s    r� Source$Z Tc:\users\i333468\documents\visual studio 2017\Projects\KursovaPS\KursovaPS\music.mp3?�6�   �� 5   
   $
��Left=�62   $��43��6M   $��
10,274,0,0q�6Y   $	��Top=�6m   $	��597��6�   $��14(�6�   $
��Bold"�6�   ���	#FF080808���	#FFF7F7F7��6   �� *QuestionText+6�   �� 5   
   $
��Left=�62   $��
10,330,0,0q�6x   $	��Top=�6�   $	��290��6�   $��37��6�   
���   �
���������6   �� *Answer1.Text+��6M   �� *Answer1.Score+��6�   �� *AnswerSelected+�� 5   
   $
��Left=�62   $��
10,372,0,0q�6x   $	��Top=�6�   $	��290��6�   $��37��6�   ���	#FF040404���	#FFF9F9F9��6   �� *Answer2.Text+��6M   �� *Answer2.Score+��6�   �� *AnswerSelected+�� 5   
   $
��Left=�62   $��317,372,0,0q�6x   $	��Top=�6�   $	��290��6�   $��37��6�   
�������
���   ���6   �� *Answer3.Text+��6M   �� *Answer3.Score+��6�   �� *AnswerSelected+�� 5   
   $
��Left=�62   $��317,330,0,0q�6x   $	��Top=�6�   $	��290��6�   $��37��6�   
����������	#FF020202��6   �� *Answer4.Text+��6M   �� *Answer4.Score+��6�   �� *AnswerSelected+�� 5   
   $
��Left=�6   $	��249��6+   $��
466,10,0,0q�68   $	��Top=�6L   $	��135��6d   ��6p   �� *Image+�� 5   
   $
��Left=�6   $��	10,10,0,0q�6-   $	��Top=�6@   $��88��6X   $��60��6c   ���	#FFFF0D0D��6�   �� *FiftyFiftyCommand+{�6�   �� *	IsEnabled+��5      �� 5      $  /KursovaPS;component/b.png��6   5      �� 5   
   -   5        $��audience��5      $
��Left=�6"   $��
114,10,0,0q�6=   $	��Top=�6Q   $��88��6i   $��60��6t   ���	#FFFF1919��6�   �� *AudienceHelpCommand+{�6�   �� *
IsEnabled2+��5      �� 5      $  /KursovaPS;component/c.png��6   5       5"      5#      