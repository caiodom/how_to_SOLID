using InterfaceSegregationPrinciple;

IPrinter basicPrinter = new BasicPrinter();
basicPrinter.Print("Basic document");

IPrinter multiPrinter = new MultifunctionPrinter();
multiPrinter.Print("Multifunction document");

IScanner scanner = new MultifunctionPrinter();
scanner.Scan("Multifunction document");

IPrinter advancedPrinter = new AdvancedPrinter();
advancedPrinter.Print("Advanced document");

IScanner advancedScanner = new AdvancedPrinter();
advancedScanner.Scan("Advanced document");

IFax faxMachine = new AdvancedPrinter();
faxMachine.Fax("Advanced document");