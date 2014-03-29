package capaPresentacion;
import javax.swing.ComboBoxModel;
import javax.swing.DefaultComboBoxModel;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextArea;
import javax.swing.JTextField;

import javax.swing.WindowConstants;
import javax.swing.SwingUtilities;

import capaLogica.Gestor;
import capaLogica.TipoPropiedad;

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
public class PantallaRegistrarPropiedad extends javax.swing.JFrame {
	private JComboBox cbxListaComunidades;
	private Gestor gestor;
	private JComboBox cbxListTiposPropiedades;
	private JComboBox cbxTipoPropiedad;
	private JLabel tipPropiedad;
	private JLabel direccion;
	private JButton btnRegresar;
	private JButton btnRegistrar;
	private JTextField telPropietario;
	private JComboBox cbxEstadoPropiedad;
	private JLabel estPropiedad;
	private JLabel jLabel1;
	private JTextArea txtDireccion;
	private JLabel nomPropietario;
	private JTextField txtNomPropietario;
	private JLabel Ubicacion;
	private JTextArea txtUbicacion;
	private JLabel numComunidad;
	private JComboBox cbxListaTiposPropiedad;
	private JTextField txtNumIdentificacion;
	private JLabel numIdent;
	private JLabel area;
	private JTextField txtArea;
	
	
	
	/**
	* Auto-generated main method to display this JFrame
	*/
	public static void main(String[] args) {
		SwingUtilities.invokeLater(new Runnable() {
			public void run() {
				PantallaRegistrarPropiedad inst = new PantallaRegistrarPropiedad();
				inst.setLocationRelativeTo(null);
				inst.setVisible(true);
			}
		});
	}
	
	public PantallaRegistrarPropiedad() {
		super();
		initGUI();
		gestor=new Gestor();
		cargarDatosComunidades();
		cargarDatosTiposPropiedades();
	}
	
	private void cargarDatosComunidades() {
		String [] listaAbogados = gestor.obtenerTodasLasComunidades();
		for(int i=0; i<listaAbogados.length;i++){

			cbxListaComunidades.addItem(listaAbogados[i]);		
		}
	}
	private void cargarDatosTiposPropiedades() {
		String [] listaTiposPropiedades = gestor.obtenerTodasLosTipos();
		for(int i=0; i<listaTiposPropiedades.length;i++){
			cbxListaTiposPropiedad.addItem(listaTiposPropiedades[i]);		
		}
	}
	
	
	private void initGUI() {
		try {
			setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
			getContentPane().setLayout(null);
			getContentPane().setBackground(new java.awt.Color(0,128,255));
			this.setResizable(false);
			this.setTitle("Registrar Propiedad");
			this.setIconImage(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/abo.jpg")).getImage());
			{
				ComboBoxModel cbxListaComunidadesModel = 
					new DefaultComboBoxModel(
							new String[] { });
				cbxListaComunidades = new JComboBox();
				getContentPane().add(cbxListaComunidades);
				cbxListaComunidades.setModel(cbxListaComunidadesModel);
				cbxListaComunidades.setBounds(214, 24, 250, 24);
				cbxListaComunidades.setBackground(new java.awt.Color(255,255,255));
			}
			{
				numComunidad = new JLabel();
				getContentPane().add(numComunidad);
				numComunidad.setText("Numero de Comunidad");
				numComunidad.setBounds(19, 24, 195, 24);
			}
			{
				ComboBoxModel cbxListaTiposPropiedadModel = 
					new DefaultComboBoxModel(
							new String[] {  });
				cbxListaTiposPropiedad = new JComboBox();
				getContentPane().add(cbxListaTiposPropiedad);
				cbxListaTiposPropiedad.setModel(cbxListaTiposPropiedadModel);
				cbxListaTiposPropiedad.setBounds(214, 65, 250, 23);
				cbxListaTiposPropiedad.setBackground(new java.awt.Color(255,255,255));
			}
			{
				tipPropiedad = new JLabel();
				getContentPane().add(tipPropiedad);
				tipPropiedad.setText("Tipo Propiedad");
				tipPropiedad.setBounds(19, 68, 195, 20);
			}
			{
				txtArea = new JTextField();
				getContentPane().add(txtArea);
				txtArea.setBounds(214, 100, 250, 23);
			}
			{
				area = new JLabel();
				getContentPane().add(area);
				area.setText("Area");
				area.setBounds(19, 102, 195, 21);
			}
			{
				txtNumIdentificacion = new JTextField();
				getContentPane().add(txtNumIdentificacion);
				txtNumIdentificacion.setBounds(214, 135, 250, 23);
			}
			{
				numIdent = new JLabel();
				getContentPane().add(numIdent);
				numIdent.setText("Numero Identificacion");
				numIdent.setBounds(19, 138, 196, 20);
			}
			{
				txtUbicacion = new JTextArea();
				getContentPane().add(txtUbicacion);
				txtUbicacion.setBounds(215, 177, 249, 51);
			}
			{
				Ubicacion = new JLabel();
				getContentPane().add(Ubicacion);
				Ubicacion.setText("Ubicacion");
				Ubicacion.setBounds(19, 185, 196, 27);
			}
			{
				txtNomPropietario = new JTextField();
				getContentPane().add(txtNomPropietario);
				txtNomPropietario.setBounds(215, 240, 249, 25);
			}
			{
				nomPropietario = new JLabel();
				getContentPane().add(nomPropietario);
				nomPropietario.setText("Nombre Propietario");
				nomPropietario.setBounds(18, 240, 197, 25);
			}
			{
				txtDireccion = new JTextArea();
				getContentPane().add(txtDireccion);
				txtDireccion.setBounds(216, 280, 248, 54);
			}
			{
				direccion = new JLabel();
				getContentPane().add(direccion);
				direccion.setText("Direccion Propiedad");
				direccion.setBounds(19, 280, 197, 47);
			}
			{
				telPropietario = new JTextField();
				getContentPane().add(telPropietario);
				telPropietario.setBounds(217, 354, 248, 23);
			}
			{
				jLabel1 = new JLabel();
				getContentPane().add(jLabel1);
				jLabel1.setText("Telefono Propietario");
				jLabel1.setBounds(19, 354, 198, 23);
			}
			{
				estPropiedad = new JLabel();
				getContentPane().add(estPropiedad);
				estPropiedad.setText("Estado Propiedad");
				estPropiedad.setBounds(19, 396, 197, 20);
			}
			{
				ComboBoxModel cbxEstadoPropiedadModel = 
					new DefaultComboBoxModel(
							new String[] { "Habitada", "Desocupada" });
				cbxEstadoPropiedad = new JComboBox();
				getContentPane().add(cbxEstadoPropiedad);
				cbxEstadoPropiedad.setModel(cbxEstadoPropiedadModel);
				cbxEstadoPropiedad.setBounds(216, 395, 248, 23);
				cbxEstadoPropiedad.setBackground(new java.awt.Color(255,255,255));
			}
			{
				btnRegistrar = new JButton();
				getContentPane().add(btnRegistrar);
				btnRegistrar.setText("Registrar");
				btnRegistrar.setBounds(19, 441, 165, 41);
				btnRegistrar.setBackground(new java.awt.Color(255,255,255));
				btnRegistrar.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/dis.gif")));
				btnRegistrar.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnRegistrar.actionPerformed, event="+evt);
						//TODO add your code for btnRegistrar.actionPerformed
						btnRegistrar_actionPerformed();
					}

				});
			}
			{
				btnRegresar = new JButton();
				getContentPane().add(btnRegresar);
				btnRegresar.setText("Regresar");
				btnRegresar.setBounds(321, 436, 143, 41);
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
			pack();
			this.setSize(516, 542);
		} catch (Exception e) {
		    //add your error handling code here
			e.printStackTrace();
		}
	}
	/*
	 numPropiedad, areaPropiedad, ubicaPropiedad,
	 numComunidad, nomPropietario, direccionPropietario, 
	 telefonoPropietario, estadoPropiedad, numIdentificacion,
	 idTipoPropiedad
	 */

	private void btnRegistrar_actionPerformed() {
		String numPropiedad, areaPropiedad, ubicaPropiedad,
		numComunidad, nomPropietario, direccionPropietario, 
		telefonoPropietario, estadoPropiedad, numIdentificacion,
		idTipoPropiedad, mjs;

		try {
			numPropiedad=txtNumIdentificacion.getText();
			areaPropiedad=txtArea.getText();
			ubicaPropiedad=txtUbicacion.getText();
			numComunidad=(String) cbxListaComunidades.getSelectedItem();
			nomPropietario=txtNomPropietario.getText();
			direccionPropietario=txtDireccion.getText();
			telefonoPropietario=telPropietario.getText();
			estadoPropiedad=(String) cbxListaTiposPropiedad.getSelectedItem();
			idTipoPropiedad=(String) cbxListaTiposPropiedad.getSelectedItem();
			TipoPropiedad tipoPropiedad=gestor.buscarTipoPropiedad(idTipoPropiedad);
			idTipoPropiedad=tipoPropiedad.getIdTipoPropiedad();
			mjs=gestor.AgregarPropiedad(numPropiedad, areaPropiedad, ubicaPropiedad, 
					numComunidad, nomPropietario, direccionPropietario, 
					telefonoPropietario, estadoPropiedad, idTipoPropiedad);
			JOptionPane.showMessageDialog(this,mjs,"Mensaje",JOptionPane.INFORMATION_MESSAGE);
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	private void btnRegresar_actionPerformed(ActionEvent evt) {
		PantallaPrincipal PP=new PantallaPrincipal();
		PP.setVisible(true);
		PantallaRegistrarPropiedad.this.dispose();
	}

}
