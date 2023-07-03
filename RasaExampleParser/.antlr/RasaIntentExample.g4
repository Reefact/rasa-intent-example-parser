grammar RasaIntentExample;

example			:	(text+ entityExample*)+
				|	(entityExample+ text*)+;
text			:	WORD+ ;
entityExample	:	'[' entityValue '](' entityName ')' ;
entityValue		:	WORD+ ;
entityName		:	WORD+ ;

WORD			:	Letter+ ;

fragment Letter :	[a-zA-Z$_]
				|	~[\u0000-\u007F\uD800-\uDBFF]
				|	[\uD800-\uDBFF] [\uDC00-\uDFFF]
				|	[ \t\r\n]+
				|	[,;.:%&#"?]
				;