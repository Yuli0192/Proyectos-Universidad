package capaPresentacion;
import javax.swing.ComboBoxModel;
import javax.swing.DefaultComboBoxModel;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import java.io.*;		//Importamos bibliotecas externas
import java.util.*;
import java.text.*;
import javax.swing.WindowConstants;
import javax.swing.SwingUtilities;

import capaLogica.Empresa;
import capaLogica.Gestor;
import capaLogica.Recibo;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

/**
* This code was edited or generated using CloudGarden's Jigloo
* SWT/Swing GUI Builder, which is free for non-commercial
* use. If Jigloo is being used commercially (ie, by a corporation,
* company or business for any purpose whatever) then you
* should purchase a license for each developer using Jigloo.
* Please visit www.cloudgarden.com for details.
* Use of Jigloo implies acceptance of these licensing terms.
* A COMMERCIAL LICENSE HAS NOT BEEN PURCHASED FOR
* THIS MACHINE, SO JIGLOO OR THIS CODE CANNOT BE USED
* LEGALLY FOR ANY CORPORATE OR COMMERCIAL PURPOSE.
*/
public class PantallaRegsitrarRecibo extends javax.swing.JFrame {
	private JTextField txtNumRecibo;
	private JLabel numRecibo;
	private JLabel fecha;
	private JLabel importe;
	private JComboBox cbxNomEmpresa;
	private JLabel nomEmpresa;
	private JComboBox cbxListaCuentas;
	private JLabel numCuentaComunidad;
	private JComboBox cbxEstado;
	private JLabel estado;
	private JLabel nomAbogago;
	private JButton btnRegresar;
	private JButton btnRegistrar;
	private JComboBox cbxListarAbogados;
	private JTextField txtImporte;
	private JTextField txtFecha;
	private Gestor gestor;
	/**
	* Auto-generated main method to display this JFrame
	*/
	public static void main(String[] args) {
		SwingUtilities.invokeLater(new Runnable() {
			public void run() {
				PantallaRegsitrarRecibo inst = new PantallaRegsitrarRecibo();
				inst.setLocationRelativeTo(null);
				inst.setVisible(true);
			}
		});
	}
	
	public PantallaRegsitrarRecibo() {
		super();
		initGUI();
		gestor=new Gestor();
		cargarDatosAbogados();
		cargarDatosCuentas();
		cargarEmpresas();
	}
	private void cargarDatosAbogados() {
		//String [] listaAdministrador = gestor.obtenerAdministrador();
		String [] listaAdministradorIds=gestor.obtenerAdministradorIds();
		for(int i=0; i<listaAdministradorIds.length;i++){
			//System.out.println(listaAdministradorIds[i]);
			cbxListarAbogados.addItem(listaAdministradorIds[i]);		
		}
	}
	
	private void cargarDatosCuentas() {
		txtFecha.setText(gestor.obtenerFechaHoy());
		String [] listaAbogados = gestor.obtenerTodasLasCuentas();
		for(int i=0; i<listaAbogados.length;i++){
			cbxListaCuentas.addItem(listaAbogados[i]);	
			
		}
	}
	public void cargarEmpresas(){
		String[] listaEmpresas=gestor.obtenerTodasLasEmpresas();
		for(int i=0; i<listaEmpresas.length;i++){
			cbxNomEmpresa.addItem(listaEmpresas[i]);	
			
		}
	}
	
	private void initGUI() {
		try {
			setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
			getContentPane().setLayout(null);
			getContentPane().setBackground(new java.awt.Color(0,128,255));
			this.setIconImage(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/abo.jpg")).getImage());
			this.setTitle("Registrar Recibo");
			{
				txtNumRecibo = new JTextField();
				getContentPane().add(txtNumRecibo);
				txtNumRecibo.setBounds(211, 54, 128, 23);
			}
			{
				numRecibo = new JLabel();
				getContentPane().add(numRecibo);
				numRecibo.setText("Numero");
				numRecibo.setBounds(23, 54, 188, 23);
			}
			{
				txtFecha = new JTextField();
				getContentPane().add(txtFecha);
				txtFecha.setBounds(211, 89, 128, 23);
			}
			{
				fecha = new JLabel();
				getContentPane().add(fecha);
				fecha.setText("Fecha");
				fecha.setBounds(23, 89, 188, 23);
			}
			{
				txtImporte = new JTextField();
				getContentPane().add(txtImporte);
				txtImporte.setBounds(211, 124, 128, 23);
			}
			{
				importe = new JLabel();
				getContentPane().add(importe);
				importe.setText("Monto");
				importe.setBounds(23, 125, 188, 20);
			}
			{
				ComboBoxModel cbxListarAbogadosModel = new DefaultComboBoxModel(new String[] { });
				cbxListarAbogados = new JComboBox();
				getContentPane().add(cbxListarAbogados);
				cbxListarAbogados.setModel(cbxListarAbogadosModel);
				cbxListarAbogados.setBounds(211, 19, 128, 23);
				cbxListarAbogados.setBackground(new java.awt.Color(255,255,255));
			}
			{
				ComboBoxModel cbxListaCuentasModel = new DefaultComboBoxModel(new String[] { });
				cbxListaCuentas = new JComboBox();
				getContentPane().add(cbxListaCuentas);
				cbxListaCuentas.setModel(cbxListaCuentasModel);
				cbxListaCuentas.setBounds(211, 199, 128, 23);
				cbxListaCuentas.setBackground(new java.awt.Color(255,255,255));
			}
			{
				btnRegistrar = new JButton();
				getContentPane().add(btnRegistrar);
				btnRegistrar.setText("Registrar");
				btnRegistrar.setBounds(23, 287, 138, 37);
				btnRegistrar.setBackground(new java.awt.Color(255,255,255));
				btnRegistrar.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/dis.gif")));
				btnRegistrar.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnRegistrar.actionPerformed, event="+evt);
						//TODO add your code for btnRegistrar.actionPerformed
						btnRegistrar_actionPerformed(evt);
					}

				});
			}
			{
				btnRegresar = new JButton();
				getContentPane().add(btnRegresar);
				btnRegresar.setText("Regresar");
				btnRegresar.setBounds(201, 287, 137, 38);
				btnRegresar.setBackground(new java.awt.Color(255,255,255));
				btnRegresar.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/salir.gif")));
				btnRegresar.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnRegresar.actionPerformed, event="+evt);
						//TODO add your code for btnRegresar.actionPerformed
						btnRegresar_actionPerformed(evt);
					}

				});
			}
			{
				nomAbogago = new JLabel();
				getContentPane().add(nomAbogago);
				nomAbogago.setText(" Identificacion Administrador");
				nomAbogago.setBounds(23, 20, 188, 20);
			}
			{
				estado = new JLabel();
				getContentPane().add(estado);
				estado.setText("Cancelado/No Cancelado");
				estado.setBounds(23, 164, 188, 22);
			}
			{
				ComboBoxModel cbxEstadoModel = 
					new DefaultComboBoxModel(
							new String[] { "Cancelado", "No Cancelado" });
				cbxEstado = new JComboBox();
				getContentPane().add(cbxEstado);
				cbxEstado.setModel(cbxEstadoModel);
				cbxEstado.setBounds(211, 164, 128, 23);
				cbxEstado.setBackground(new java.awt.Color(255,255,255));
			}
			{
				numCuentaComunidad = new JLabel();
				getContentPane().add(numCuentaComunidad);
				numCuentaComunidad.setText("Cuenta Comunidad");
				numCuentaComunidad.setBounds(23, 199, 138, 23);
			}
			{
				nomEmpresa = new JLabel();
				getContentPane().add(nomEmpresa);
				nomEmpresa.setText("Nombre Empresa");
				nomEmpresa.setBounds(23, 239, 126, 25);
			}
			{
				ComboBoxModel cbxNomEmpresaModel = 
					new DefaultComboBoxModel(
							new String[] { });
				cbxNomEmpresa = new JComboBox();
				getContentPane().add(cbxNomEmpresa);
				cbxNomEmpresa.setModel(cbxNomEmpresaModel);
				cbxNomEmpresa.setBounds(173, 240, 165, 23);
				cbxNomEmpresa.setBackground(new java.awt.Color(255,255,255));
			}

			pack();
			this.setSize(379, 389);
		} catch (Exception e) {
		    //add your error handling code here
			e.printStackTrace();
		}
	}
	

	private void btnRegistrar_actionPerformed(ActionEvent evt) {
		String numRecibo,fecha,numAdministrador,estado,mjs,numCuenta,nomEmpresa,numEmpresa;
		int importe;
		try {
			numRecibo=txtNumRecibo.getText();
			fecha=txtFecha.getText();
			importe=Integer.parseInt(txtImporte.getText());
			numAdministrador=(String) cbxListarAbogados.getSelectedItem();
			estado= (String) cbxEstado.getSelectedItem();
			numCuenta=(String) cbxListaCuentas.getSelectedItem();
			nomEmpresa=(String) cbxNomEmpresa.getSelectedItem();
			//System.out.println(nomEmpresa);
			Empresa empresa=gestor.buscarEmpresaPorNombre(nomEmpresa);
			numEmpresa=empresa.getNumEmpresa();
			//numRecibo, fecha, importe, estado, numAdministrador,numCuenta
			//String pnumRecibo,String pfecha,int pimporte, String pestado, String pnumAdministrador,String pnumCuenta
			cancelarRecibo(numRecibo, fecha, importe, estado, numAdministrador,numCuenta,numEmpresa);
			
			
			//JOptionPane.showMessageDialog(this,mjs,"Mensaje",JOptionPane.INFORMATION_MESSAGE);
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
	}
	private void btnRegresar_actionPerformed(ActionEvent evt) {
		PantallaPrincipal PP=new PantallaPrincipal();
		PP.setVisible(true);
		PantallaRegsitrarRecibo.this.dispose();
	}
	//numRecibo, fecha, importe, estado, numAdministrador,numCuenta
	//String pnumRecibo,String pfecha,int pimporte,String pestado,String pidAdministrador,String pnumCuenta
	private void cancelarRecibo(String pnumRecibo,String pfecha,int pimporte, String pestado, String pnumAdministrador,String pnumCuenta, String pnumEmpresa){
		String mjs1,mjs2,mjs3;	
		if(pestado.equals("Cancelado")){	
			try {   //String pnumRecibo,String pfecha,int pimporte,String pestado,String pidAdministrador,String pnumCuenta, String pnumEmpresa
				mjs2=gestor.AgregarRecibo(pnumRecibo, pfecha, pimporte, pestado, pnumAdministrador,pnumCuenta,pnumEmpresa);			
				JOptionPane.showMessageDialog(this,mjs2,"Mensaje",JOptionPane.INFORMATION_MESSAGE);
				if(!(mjs2=="El numero del recibo ya existe")){
					mjs1=gestor.pagarRecibo(pnumCuenta, pimporte);
					//mjs3=mjs2+mjs1;
					JOptionPane.showMessageDialog(this,mjs1,"Mensaje",JOptionPane.INFORMATION_MESSAGE);
				}				
			} catch (Exception e) {
				
				// TODO Auto-generated catch block
				//e.printStackTrace();
			}	
		}else{
			try {
				mjs1=gestor.AgregarRecibo(pnumRecibo, pfecha, pimporte, pestado, pnumAdministrador,pnumCuenta,pnumEmpresa);
				JOptionPane.showMessageDialog(this,mjs1,"Mensaje",JOptionPane.INFORMATION_MESSAGE);
			} catch (Exception e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
	}
}
