grammar SkillExample;

example			:	( text+ ( '{{' argumentName '}}' )* )+
				|	(( '{{' argumentName '}}' )+ text*)+ ;
text			:	WORD+ ;
argumentName	:	WORD+ ;

WORD			:	Letter+ ;

fragment Letter :	[\u0000-\u007A]
				|	[\u007C]
				|	[\u007E-\u00FF] ;