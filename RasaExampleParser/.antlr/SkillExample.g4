grammar SkillExample;

example			:	( text+ ( '{{' argumentName '}}' )* )+
				|	(( '{{' argumentName '}}' )+ text*)+ ;
text			:	WORD+ ;
argumentName	:	WORD+ ;

WORD			:	Letter+ ;

fragment Letter :	[a-zA-Z$_0-9\-]
				|	~[\u0000-\u007F\uD800-\uDBFF]
				|	[\uD800-\uDBFF] [\uDC00-\uDFFF]
				|	[ \t\r\n]+
				|	[,;.:%&#"?]
				;