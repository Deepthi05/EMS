<?php
/** [BEGIN HEADER] **
 * COPYRIGHT: (c) 2005 Brice Burgess / All Rights Reserved    
 * LICENSE: http://www.gnu.org/copyleft.html GNU/GPL 
 * AUTHOR: Brice Burgess <bhb@iceburg.net>
 * SOURCE: http://pommo.sourceforge.net/
 *
 *  :: RESTRICTIONS ::
 *  1. This header must accompany all portions of code contained within.
 *  2. You must notify the above author of modifications to contents within.
 * 
 ** [END HEADER]**/

/**********************************
	INITIALIZATION METHODS
 *********************************/
define('_IS_VALID', TRUE);
define('_poMMo_embed', TRUE);

$dirname = dirname(__FILE__);
require($dirname.'/bootstrap.php');

$poMMo = & fireup('install');
$dbo = & $poMMo->_dbo;

/**********************************
	SETUP TEMPLATE, PAGE
 *********************************/
$smarty = & bmSmartyInit();

// subscription forms will be activated from this template
$smarty->prepareForSubscribeForm();

// assign referer since this is an embedded form
$smarty->assign('referer',htmlspecialchars($_SERVER['PHP_SELF']));

$smarty->display('subscribe/form.mini.tpl');
?>